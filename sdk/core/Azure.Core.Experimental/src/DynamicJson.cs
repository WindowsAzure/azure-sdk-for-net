﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace Azure.Core
{
    /// <summary>
    ///
    /// </summary>
    public class DynamicJson : IDynamicMetaObjectProvider
    {
        private struct Number
        {
            public Number(in JsonElement element)
            {
                _hasDouble = element.TryGetDouble(out _double);
                _hasLong = element.TryGetInt64(out _long);
            }

            private long _long;
            private bool _hasLong;
            private double _double;
            private bool _hasDouble;

            public void WriteTo(Utf8JsonWriter writer)
            {
                if (_hasDouble)
                {
                    writer.WriteNumberValue(_double);
                }
                else
                {
                    writer.WriteNumberValue(_long);
                }
            }
        }

        private readonly JsonElement _element;
        private readonly JsonValueKind _kind;
        private Dictionary<string, DynamicJson>? _objectRepresentation;
        private List<DynamicJson>? _arrayRepresentation;
        private object? _value;

        /// <summary>
        ///
        /// </summary>
        /// <param name="element"></param>
        internal DynamicJson(JsonElement element)
        {
            _element = element;
            _kind = element.ValueKind;
            switch (element.ValueKind)
            {
                case JsonValueKind.Object:
                    _objectRepresentation = new Dictionary<string, DynamicJson>();
                    foreach (var item in element.EnumerateObject())
                    {
                        _objectRepresentation[item.Name] = new DynamicJson(item.Value);
                    }
                    break;
                case JsonValueKind.Array:
                    _arrayRepresentation = new List<DynamicJson>();
                    foreach (var item in element.EnumerateArray())
                    {
                        _arrayRepresentation.Add(new DynamicJson(item));
                    }
                    break;
                case JsonValueKind.String:
                    _value = element.GetString();
                    break;
                case JsonValueKind.Number:
                    // TODO:
                    _value = new Number(element);
                    break;
                case JsonValueKind.True:
                case JsonValueKind.False:
                    _value = element.GetBoolean();
                    break;
                case JsonValueKind.Null:
                    _value = null;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(element), "Unsupported element kind");
            }
        }

        private DynamicJson(IEnumerable<KeyValuePair<string,DynamicJson>> properties)
        {
            _kind = JsonValueKind.Object;
            _objectRepresentation = new Dictionary<string, DynamicJson>();
            foreach (var property in properties)
            {
                _objectRepresentation[property.Key] = property.Value;
            }
        }

        private DynamicJson(IEnumerable<DynamicJson> array)
        {
            _kind = JsonValueKind.Array;
            _arrayRepresentation = new List<DynamicJson>(array);
        }

        private DynamicJson(object? value)
        {
            _value = value;
            _kind = value == null ? JsonValueKind.Null : JsonValueKind.String;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static DynamicJson Parse(string json)
        {
            return Create(JsonDocument.Parse(json).RootElement);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static DynamicJson Create(JsonElement element)
        {
            return new DynamicJson(element);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="writer"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void WriteTo(Utf8JsonWriter writer)
        {
            switch (_kind)
            {
                case JsonValueKind.Null:
                case JsonValueKind.String:
                    writer.WriteStringValue((string?)_value);
                    break;
                case JsonValueKind.Number:
                    ((Number) _value!).WriteTo(writer);
                    break;
                case JsonValueKind.True:
                case JsonValueKind.False:
                    writer.WriteBooleanValue((bool)_value!);
                    break;
                case JsonValueKind.Object:
                    writer.WriteStartObject();
                    foreach (var property in EnsureObject())
                    {
                        writer.WritePropertyName(property.Key);
                        property.Value.WriteTo(writer);
                    }
                    writer.WriteEndObject();
                    break;
                case JsonValueKind.Array:
                    writer.WriteStartArray();
                    foreach (var item in EnsureArray())
                    {
                        item.WriteTo(writer);
                    }
                    writer.WriteEndArray();
                    break;
            }
        }
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public JsonElement AsJsonElement()
        {
            var memoryStream = new MemoryStream();
            var writer = new Utf8JsonWriter(memoryStream);
            WriteTo(writer);
            return JsonDocument.Parse(memoryStream.ToArray()).RootElement;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            using var memoryStream = new MemoryStream();
            using (var writer = new Utf8JsonWriter(memoryStream))
            {
                WriteTo(writer);
            }
            return Encoding.UTF8.GetString(memoryStream.ToArray());
        }

        /// <inheritdoc />
        DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) => new MetaObject(parameter, this);

        private object GetValue(string propertyName)
        {
            if (propertyName == "Length" && _kind == JsonValueKind.Array)
            {
                return EnsureArray().Count;
            }

            if (EnsureObject().TryGetValue(propertyName, out DynamicJson element))
            {
                return element;
            }

            throw new InvalidOperationException($"Property {propertyName} not found");
        }

        private object? SetValue(string propertyName, object? value)
        {
            if (!(value is DynamicJson json))
            {
                json = new DynamicJson(value);
            }

            EnsureObject()[propertyName] = json;
            return value;
        }

        private List<DynamicJson> EnsureArray()
        {
            if (_kind != JsonValueKind.Array)
            {
                throw new InvalidOperationException($"Expected kind to be array but was {_kind} instead");
            }

            Debug.Assert(_arrayRepresentation != null);
            return _arrayRepresentation!;
        }

        private Dictionary<string, DynamicJson> EnsureObject()
        {
            if (_kind != JsonValueKind.Object)
            {
                throw new InvalidOperationException($"Expected kind to be object but was {_kind} instead");
            }

            Debug.Assert(_objectRepresentation != null);
            return _objectRepresentation!;
        }

        private object? EnsureValue()
        {
            if (_kind == JsonValueKind.Object || _kind == JsonValueKind.Array)
            {
                throw new InvalidOperationException($"Expected kind to be value but was {_kind} instead");
            }

            return _value;
        }

        private object GetValueAt(int index)
        {
            return EnsureArray()[index];
        }

        private object? ConvertTo(Type type)
        {
            Debug.Assert(type != null);

            if (type == typeof(IEnumerable))
            {
                return EnsureArray();
            }

            var value = EnsureValue();

            if (value == null)
            {
                return null;
            }

            if (type == typeof(long))
            {
                return (long)value;
            }
            if (type == typeof(int))
            {
                return (int)value;
            }
            if (type == typeof(bool))
            {
                return (bool)value;
            }

            if (type == typeof(string))
            {
                return (string)value;
            }

            throw new InvalidOperationException($"Unknown type {type}");
        }

        private class MetaObject : DynamicMetaObject
        {
            internal MetaObject(Expression parameter, IDynamicMetaObjectProvider value) : base(parameter, BindingRestrictions.Empty, value)
            { }


            public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
            {
                var targetObject = Expression.Convert(Expression, LimitType);
                var methodIplementation = typeof(DynamicJson).GetMethod(nameof(GetValue), BindingFlags.NonPublic | BindingFlags.Instance);
                var arguments = new Expression[] { Expression.Constant(binder.Name) };

                var getPropertyCall = Expression.Call(targetObject, methodIplementation, arguments);
                var restrictions = BindingRestrictions.GetTypeRestriction(Expression, LimitType);
                DynamicMetaObject getProperty = new DynamicMetaObject(getPropertyCall, restrictions);
                return getProperty;
            }

            public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
            {
                Expression targetObject = Expression.Convert(Expression, LimitType);
                var methodImplementation = typeof(DynamicJson).GetMethod(nameof(SetValue), BindingFlags.NonPublic | BindingFlags.Instance);
                var arguments = new Expression[2] { Expression.Constant(binder.Name), Expression.Convert(value.Expression, typeof(object)) };

                Expression setPropertyCall = Expression.Call(targetObject, methodImplementation, arguments);
                BindingRestrictions restrictions = BindingRestrictions.GetTypeRestriction(Expression, LimitType);
                DynamicMetaObject setProperty = new DynamicMetaObject(setPropertyCall, restrictions);
                return setProperty;
            }

            public override DynamicMetaObject BindConvert(ConvertBinder binder)
            {
                var sourceInstance = Expression.Convert(Expression, LimitType);
                var destinationType = binder.Type;
                var destinationTypeExpression = Expression.Constant(destinationType);

                var restrictions = BindingRestrictions.GetTypeRestriction(Expression, LimitType);

                var methodIplementation = typeof(DynamicJson).GetMethod(nameof(ConvertTo), BindingFlags.NonPublic | BindingFlags.Instance);
                Expression expression = Expression.Call(sourceInstance, methodIplementation, new Expression[] { destinationTypeExpression });
                expression = Expression.Convert(expression, binder.Type);
                return new DynamicMetaObject(expression, restrictions);
            }

            public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
            {
                if (indexes.Length != 1) throw new InvalidOperationException();
                var index = indexes[0].Expression;

                var targetObject = Expression.Convert(Expression, LimitType);
                var methodIplementation = typeof(DynamicJson).GetMethod(nameof(GetValueAt), BindingFlags.NonPublic | BindingFlags.Instance);
                var arguments = new[] { index };

                var getPropertyCall = Expression.Call(targetObject, methodIplementation, arguments);
                var restrictions = binder.FallbackGetIndex(this, indexes).Restrictions; // TODO: all these restrictions are a hack. Tthey need to be cleaned up.
                DynamicMetaObject getProperty = new DynamicMetaObject(getPropertyCall, restrictions);
                return getProperty;
            }

            public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
            {
                return base.BindSetIndex(binder, indexes, value);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
#pragma warning disable CA1720 // Identifier 'Object' contains type name
        public static DynamicJson Object()
        {
            return Object(System.Array.Empty<KeyValuePair<string, DynamicJson>>());
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static DynamicJson Object(IEnumerable<KeyValuePair<string, DynamicJson>> values)
        {
            return new DynamicJson(values);
        }
#pragma warning restore CA1720

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static DynamicJson Array()
        {
            return Array(System.Array.Empty<DynamicJson>());
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static DynamicJson Array(IEnumerable<DynamicJson> values)
        {
            return new DynamicJson(values);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static DynamicJson Array(params DynamicJson[] values)
        {
            return new DynamicJson(values);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator DynamicJson(int value)
        {
            return new DynamicJson(value);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator DynamicJson(string? value)
        {
            return new DynamicJson(value);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="value"></param>
        /// <param name="options"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static DynamicJson Serialize<T>(T value, JsonSerializerOptions? options = null)
        {
            var serialized = JsonSerializer.Serialize<T>(value, options);
            return new DynamicJson(JsonDocument.Parse(serialized).RootElement);
        }
    }
}