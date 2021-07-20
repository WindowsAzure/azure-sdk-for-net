// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Creator.Models
{
    /// <summary> Point In Polygon Result Object. </summary>
    public partial class PointInPolygonResult
    {
        /// <summary> Initializes a new instance of PointInPolygonResult. </summary>
        internal PointInPolygonResult()
        {
            IntersectingGeometries = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PointInPolygonResult. </summary>
        /// <param name="pointInPolygons"> Point In Polygons Property. </param>
        /// <param name="intersectingGeometries"> Geometries array. </param>
        internal PointInPolygonResult(bool? pointInPolygons, IReadOnlyList<string> intersectingGeometries)
        {
            PointInPolygons = pointInPolygons;
            IntersectingGeometries = intersectingGeometries;
        }

        /// <summary> Point In Polygons Property. </summary>
        public bool? PointInPolygons { get; }
        /// <summary> Geometries array. </summary>
        public IReadOnlyList<string> IntersectingGeometries { get; }
    }
}
