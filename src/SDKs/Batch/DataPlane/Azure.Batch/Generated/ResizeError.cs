// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An error that occurred when resizing a pool.
    /// </summary>
    public partial class ResizeError : IPropertyMetadata
    {
        private readonly string code;
        private readonly string message;
        private readonly IReadOnlyList<NameValuePair> values;

        #region Constructors

        internal ResizeError(Models.ResizeError protocolObject)
        {
            this.code = protocolObject.Code;
            this.message = protocolObject.Message;
            this.values = NameValuePair.ConvertFromProtocolCollectionReadOnly(protocolObject.Values);
        }

        #endregion Constructors

        #region ResizeError

        /// <summary>
        /// Gets a code for the pool resize error. See <see cref="Common.PoolResizeErrorCodes"/> for possible values.
        /// </summary>
        public string Code
        {
            get { return this.code; }
        }

        /// <summary>
        /// Gets a message describing the pool resize error, intended to be suitable for display in a user interface.
        /// </summary>
        public string Message
        {
            get { return this.message; }
        }

        /// <summary>
        /// Gets a list of additional error details related to the pool resize error.
        /// </summary>
        public IReadOnlyList<NameValuePair> Values
        {
            get { return this.values; }
        }

        #endregion // ResizeError

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods


        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<ResizeError> ConvertFromProtocolCollection(IEnumerable<Models.ResizeError> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ResizeError> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ResizeError(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<ResizeError> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.ResizeError> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ResizeError> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ResizeError(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<ResizeError> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.ResizeError> protoCollection)
        {
            IReadOnlyList<ResizeError> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new ResizeError(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}