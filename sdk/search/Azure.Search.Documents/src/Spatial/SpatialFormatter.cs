﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Globalization;
using System.Text;
using Azure.Core;
using Azure.Core.GeoJson;

namespace Azure.Search.Documents
{
    /// <summary>
    /// Encodes geographic data from both Azure.Core and Microsoft.Spatial for use in OData filters.
    /// </summary>
    internal static class SpatialFormatter
    {
        /// <summary>
        /// Encodes the longitude and latitude of points or positions for use in OData filters.
        /// </summary>
        /// <param name="longitude">The longitude to encode, which may also be known as Y.</param>
        /// <param name="latitude">The latitude to encode, which may also be known as X.</param>
        /// <returns>The OData filter-encoded POINT string.</returns>
        public static string EncodePoint(double longitude, double latitude)
        {
            const int maxLength =
                19 +       // "geography'POINT( )'".Length
                2 *        // Lat and Long each have:
                   (15 +   //     Maximum precision for a double (without G17)
                     1 +   //     Optional decimal point
                     1);   //     Optional negative sign

            return new StringBuilder(maxLength)
                .Append("geography'POINT(")
                .Append(JsonSerialization.Double(longitude, CultureInfo.InvariantCulture))
                .Append(' ')
                .Append(JsonSerialization.Double(latitude, CultureInfo.InvariantCulture))
                .Append(")'")
                .ToString();
        }

        // Support for both Azure.Core.GeoJson and Microsoft.Spatial encoding are duplicated
        // below to avoid extraneous allocations for adapters and to consolidate them to a single
        // source file for easier maintenance.

        /// <summary>
        /// Encodes a polygon for use in OData filters.
        /// </summary>
        /// <param name="line">The <see cref="GeoLineString"/> to encode.</param>
        /// <returns>The OData filter-encoded POLYGON string.</returns>
        /// <exception cref="ArgumentException">The <paramref name="line"/> has fewer than 4 points, or the first and last points do not match.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="line"/> or <see cref="GeoLineString.Coordinates"/> is null.</exception>
        public static string EncodePolygon(GeoLineString line)
        {
            Argument.AssertNotNull(line, nameof(line));

            if (line.Coordinates.Count < 4)
            {
                throw new ArgumentException(
                    $"A {nameof(GeoLineString)} must have at least four {nameof(GeoLineString.Coordinates)} to form a searchable polygon.",
                    $"{nameof(line)}");
            }
            else if (line.Coordinates[0] != line.Coordinates[line.Coordinates.Count - 1])
            {
                throw new ArgumentException(
                    $"A {nameof(GeoLineString)} must have matching first and last {nameof(GeoLineString.Coordinates)} to form a searchable polygon.",
                    $"{nameof(line)}");
            }

            return EncodePolygon(new GeoLinearRing(line.Coordinates));
        }

        public static string EncodePolygon(GeoLinearRing linearRing)
        {
            Argument.AssertNotNull(linearRing, nameof(linearRing));

            StringBuilder odata = new ("geography'POLYGON((");

            bool first = true;
            foreach (GeoPosition position in linearRing.Coordinates)
            {
                if (!first)
                {
                    odata.Append(',');
                }
                else
                {
                    first = false;
                }

                odata.Append(JsonSerialization.Double(position.Longitude, CultureInfo.InvariantCulture))
                    .Append(' ')
                    .Append(JsonSerialization.Double(position.Latitude, CultureInfo.InvariantCulture));
            }

            return odata
                .Append("))'")
                .ToString();
        }

        /// <summary>
        /// Encodes a polygon for use in OData filters.
        /// <seealso cref="EncodePolygon(GeoLinearRing)"/>
        /// </summary>
        /// <param name="polygon">The <see cref="GeoPolygon"/> to encode.</param>
        /// <returns>The OData filter-encoded POLYGON string.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="polygon"/> or <see cref="GeoPolygon.Rings"/> is null.</exception>
        public static string EncodePolygon(GeoPolygon polygon)
        {
            Argument.AssertNotNull(polygon, nameof(polygon));
            Argument.AssertNotNull(polygon.Rings, $"{nameof(polygon)}.{nameof(polygon.Rings)}");

            if (polygon.Rings.Count != 1)
            {
                throw new ArgumentException(
                    $"A {nameof(GeoPolygon)} must have exactly one {nameof(GeoPolygon.Rings)} to form a searchable polygon.",
                    $"{nameof(polygon)}");
            }

            return EncodePolygon(polygon.Rings[0]);
        }

        /// <summary>
        /// Encodes a polygon for use in OData filters.
        /// </summary>
        /// <param name="line">The <see cref="GeoLineStringProxy"/> to encode.</param>
        /// <returns>The OData filter-encoded POLYGON string.</returns>
        /// <exception cref="ArgumentException">The <paramref name="line"/> has fewer than 4 points, or the first and last points do not match.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="line"/> or <see cref="GeoLineStringProxy.Coordinates"/> is null.</exception>
        public static string EncodePolygon(GeoLineStringProxy line)
        {
            Argument.AssertNotNull(line, nameof(line));
            Argument.AssertNotNull(line.Coordinates, $"{nameof(line)}.{nameof(line.Coordinates)}");

            if (line.Coordinates.Count < 4)
            {
                throw new ArgumentException(
                    $"A GeographyLineString must have at least four Points to form a searchable polygon.",
                    $"{nameof(line)}");
            }
            else if (line.Coordinates[0] != line.Coordinates[line.Coordinates.Count - 1])
            {
                throw new ArgumentException(
                    $"A GeographyLineString must have matching first and last Points to form a searchable polygon.",
                    $"{nameof(line)}");
            }

            StringBuilder odata = new StringBuilder("geography'POLYGON((");

            bool first = true;
            foreach (GeoPositionProxy position in line.Coordinates)
            {
                if (!first)
                {
                    odata.Append(',');
                }
                else
                {
                    first = false;
                }

                odata.Append(JsonSerialization.Double(position.Longitude, CultureInfo.InvariantCulture))
                    .Append(' ')
                    .Append(JsonSerialization.Double(position.Latitude, CultureInfo.InvariantCulture));
            }

            return odata
                .Append("))'")
                .ToString();
        }

        public static string EncodePolygon(GeoLinearRingProxy linearRing)
        {
            Argument.AssertNotNull(linearRing, nameof(linearRing));

            StringBuilder odata = new ("geography'POLYGON((");

            bool first = true;
            foreach (GeoPositionProxy position in linearRing.Coordinates)
            {
                if (!first)
                {
                    odata.Append(',');
                }
                else
                {
                    first = false;
                }

                odata.Append(JsonSerialization.Double(position.Longitude, CultureInfo.InvariantCulture))
                    .Append(' ')
                    .Append(JsonSerialization.Double(position.Latitude, CultureInfo.InvariantCulture));
            }

            return odata
                .Append("))'")
                .ToString();
        }

        /// <summary>
        /// Encodes a polygon for use in OData filters.
        /// <seealso cref="EncodePolygon(GeoLineStringProxy)"/>
        /// </summary>
        /// <param name="polygon">The <see cref="GeoPolygonProxy"/> to encode.</param>
        /// <returns>The OData filter-encoded POLYGON string.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="polygon"/> or <see cref="GeoPolygonProxy.Rings"/> is null.</exception>
        public static string EncodePolygon(GeoPolygonProxy polygon)
        {
            Argument.AssertNotNull(polygon, nameof(polygon));
            Argument.AssertNotNull(polygon.Rings, $"{nameof(polygon)}.{nameof(polygon.Rings)}");

            if (polygon.Rings.Count != 1)
            {
                throw new ArgumentException(
                    $"A GeographyPolygon must have exactly one Rings to form a searchable polygon.",
                    $"{nameof(polygon)}");
            }

            return EncodePolygon(polygon.Rings[0]);
        }
    }
}
