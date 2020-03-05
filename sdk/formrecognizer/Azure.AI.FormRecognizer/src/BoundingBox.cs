﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Azure.AI.FormRecognizer.Models
{
    public class BoundingBox
    {
        internal BoundingBox(ICollection<float> boundingBox)
        {
            // TODO: improve perf here?
            float[] bbPoints = boundingBox.ToArray();

            int count = bbPoints.Length / 2;

            Points = new PointF[count];
            for (int i = 0; i < count; i++)
            {
                Points[i] = new PointF(bbPoints[2 * i], bbPoints[(2 * i) + 1]);
            }
        }

        public PointF[] Points { get; }
    }
}
