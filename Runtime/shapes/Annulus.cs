using System;
using ShapeCalculations.Random;
using static ShapeCalculations.Math.Mathf;

namespace ShapeCalculations.Shapes
{
    public class Annulus : IRandomPointable
    {
        public float InnerRadius { get; private set; }
        public float InnerDiameter { get => 2f * this.InnerRadius; }
        public float InnerPerimeter { get => 2f * PI * this.InnerRadius; }
        public float OuterRadius { get; private set; }
        public float OuterDiameter { get => 2f * this.OuterRadius; }
        public float OuterPerimeter { get => 2f * PI * this.OuterRadius; }
        public float Perimeter { get => 2f * PI * (this.OuterRadius + this.InnerRadius); }
        public float Area { get => (float)(PI * (Pow(this.OuterRadius, 2) - Pow(this.InnerRadius, 2))); }

        public Annulus(float innerRadius, float outerRadius)
        {
            this.InnerRadius = innerRadius;
            this.OuterRadius = outerRadius;
        }

        // Source: https://stackoverflow.com/questions/9048095/create-random-number-within-an-annulus
        public (float, float) GetRandomPoint()
        {
            var theta = Randomf.Range(0f, 2f * PI);
            var A = 2f / (Pow(this.OuterRadius, 2) - Pow(this.InnerRadius, 2)); // A = 2 / (R^2 - r^2)
            var r = Sqrt(2f * Randomf.Range(0f, 1f) / A + Pow(this.InnerRadius, 2));
            var x = r * Cos(theta);
            var y = r * Sin(theta);
            return (x, y);
        }
    }
}
