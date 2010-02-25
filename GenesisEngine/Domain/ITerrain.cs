﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace GenesisEngine
{
    public interface ITerrain
    {
        void Update(TimeSpan elapsedTime, DoubleVector3 cameraLocation, DoubleVector3 planetLocation, ClippingPlanes clippingPlanes);

        void Draw(DoubleVector3 cameraLocation, Matrix originBasedViewMatrix, Matrix projectionMatrix);
    }
}