﻿using System;
namespace Adv_c__revision
{
    internal class MutablePoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MutablePoint()
        {
            X = 0;
            Y = 0;
        }

        public MutablePoint(int x, int y)
        {
            X = x;
            Y = y;

        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
