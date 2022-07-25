using System;
using Shaper.Random;
using static Shaper.Math.Mathf;

namespace Shaper.Shapes
{
    public class Ring : Shape2D, IShape2D
    {
        public Circle InnerCircle { get; private set; }
        public Circle OuterCircle { get; private set; }
        public float Perimeter { get => 2f * PI * (this.OuterCircle.Radius + this.InnerCircle.Radius); }
        public float Area { get => (float)(PI * (Pow(this.OuterCircle.Radius, 2) - Pow(this.InnerCircle.Radius, 2))); }

        public Ring(float innerRadius, float outerRadius)
        {
            this.InnerCircle = new Circle(innerRadius);
            this.OuterCircle = new Circle(outerRadius);
        }

        // Source: https://stackoverflow.com/questions/9048095/create-random-number-within-an-annulus
        public override (float, float) GetRandomPoint()
        {
            var theta = Randomf.Range(0f, 2f * PI);
            var A = 2f / (Pow(this.OuterCircle.Radius, 2) - Pow(this.InnerCircle.Radius, 2)); // A = 2 / (R^2 - r^2)
            var r = Sqrt(2f * Randomf.Range(0f, 1f) / A + Pow(this.InnerCircle.Radius, 2));
            var x = r * Cos(theta);
            var y = r * Sin(theta);
            return (x, y);
        }
    }
}
