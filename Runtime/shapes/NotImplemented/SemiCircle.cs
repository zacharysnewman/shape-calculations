using System;
using Shaper.Random;
using static Shaper.Math.Mathf;

namespace Shaper.Shapes
{
    public class SemiCircle : Shape2D, IShape2D
    {
        public float Area { get => throw new NotImplementedException(); }
        public float Perimeter { get => throw new NotImplementedException(); }

        public SemiCircle(float radius)
        {
            throw new NotImplementedException();
        }

        public override (float, float) GetRandomPoint() => throw new NotImplementedException();
    } 
}
