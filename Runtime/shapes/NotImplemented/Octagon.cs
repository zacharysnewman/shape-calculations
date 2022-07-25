using System;
using Shaper.Random;
using static Shaper.Math.Mathf;

namespace Shaper.Shapes
{
    public class Octagon : Shape2D, IShape2D
    {
        public Octagon()
        {
            throw new NotImplementedException();
        }

        public float Area => throw new NotImplementedException();
        public float Perimeter => throw new NotImplementedException();

        public override (float, float) GetRandomPoint() => throw new NotImplementedException();
    }
}
