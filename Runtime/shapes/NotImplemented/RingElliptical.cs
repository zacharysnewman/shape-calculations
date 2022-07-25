using System;
using Shaper.Random;
using static Shaper.Math.Mathf;

namespace Shaper.Shapes
{
    public class RingElliptical : Shape2D, IShape2D
    {
        public Ellipse InnerEllipse { get; private set; }
        public Ellipse OuterEllipse { get; private set; }
        public float Perimeter { get => throw new NotImplementedException(); }
        public float Area { get => throw new NotImplementedException(); }

        public RingElliptical(float innerRadiusWidth, float innerRadiusHeight, float outerRadiusWidth, float outerRadiusHeight)
        {
            this.InnerEllipse = new Ellipse(innerRadiusWidth, innerRadiusHeight);
            this.OuterEllipse = new Ellipse(outerRadiusWidth, outerRadiusHeight);
        }

        // Source: https://stackoverflow.com/questions/9048095/create-random-number-within-an-annulus
        public override (float, float) GetRandomPoint()
        {
            throw new NotImplementedException();
        }
    }
}
