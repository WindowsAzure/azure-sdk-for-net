﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Azure.Search.Documents
{
    /// <summary>
    /// Search extension methods.
    /// </summary>
    internal static partial class SearchExtensions
    {
        /// <summary>
        /// Assert that the given URI uses HTTPS as its scheme.
        /// </summary>
        /// <param name="endpoint">The URI to validate.</param>
        /// <param name="paramName">
        /// The name of the parameter for this URI, to use with an
        /// <see cref="ArgumentException"/>.
        /// </param>
        /// <exception cref="ArgumentException">
        /// Thrown when the <paramref name="endpoint"/> is not using HTTPS as
        /// its scheme.
        /// </exception>
        public static void AssertHttpsScheme(this Uri endpoint, string paramName)
        {
            Debug.Assert(endpoint != null);
            if (!string.Equals(endpoint.Scheme, Uri.UriSchemeHttps, StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException($"{paramName} only supports {Uri.UriSchemeHttps}.", paramName);
            }
        }

        /// <summary>
        /// Get the name of the Search Service from its
        /// <paramref name="endpoint"/>.
        /// </summary>
        /// <param name="endpoint">The endpoint of the Search Service.</param>
        /// <returns>The name of the Search Service.</returns>
        public static string GetSearchServiceName(this Uri endpoint)
        {
            Debug.Assert(endpoint != null);
            string host = endpoint.Host;
            int separator = host.IndexOf('.');
            return (separator > 0) ?
                host.Substring(0, separator) :
                null;
        }

        /// <summary>
        /// Join a collection of strings into a single comma separated string.
        /// If the collection is null or empty, a null string will be returned.
        /// </summary>
        /// <param name="items">The items to join.</param>
        /// <returns>The items joined together by commas.</returns>
        public static string CommaJoin(this IEnumerable<string> items) =>
            items != null && items.Count() > 0 ? string.Join(",", items) : null;

        /// <summary>
        /// Split a collection of strings by commas.
        /// </summary>
        /// <param name="value">The value to split.</param>
        /// <returns>A collection of individual values.</returns>
        public static IList<string> CommaSplit(string value) =>
            string.IsNullOrEmpty(value) ?
                new List<string>() :
                // TODO: #10600 - Verify we don't need to worry about escaping
                new List<string>(value.Split(','));

        /// <summary>
        /// Joins a collection of items using <see cref="object.ToString"/> with the given <paramref name="separator"/>.
        /// </summary>
        /// <typeparam name="T">The non-nullable type of item to join.</typeparam>
        /// <param name="items">The collection of items to join.</param>
        /// <param name="separator">The separator between items to join. The default is a comma.</param>
        /// <returns>
        /// A collection of items using <see cref="object.ToString"/> with the given <paramref name="separator"/>,
        /// or null if <paramref name="items"/> is null or empty, or contains only null or empty values.
        /// </returns>
        public static string JoinAsString<T>(this IEnumerable<T> items, char separator = ',')
            where T : notnull
        {
            if (items != null && items.Count() > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (T item in items)
                {
                    string value = item.ToString();
                    if (!string.IsNullOrEmpty(value))
                    {
                        if (sb.Length > 0)
                        {
                            sb.Append(separator);
                        }

                        sb.Append(value);
                    }
                }

                if (sb.Length > 0)
                {
                    return sb.ToString();
                }
            }

            return null;
        }
    }
}
