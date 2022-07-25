using System;
using Shaper.Random;
using static Shaper.Math.Mathf;

namespace Shaper.Shapes
{
    public class Parallelogram : Shape2D, IShape2D
    {
        public Parallelogram()
        {
            throw new NotImplementedException();
        }

        public float Area => throw new NotImplementedException();
        public float Perimeter => throw new NotImplementedException();

        public override (float, float) GetRandomPoint() => throw new NotImplementedException();
    }
}
