using System;
using Shaper.Random;
using static Shaper.Math.Mathf;

namespace Shaper.Shapes
{
    public class Rectangle : IRandomPointable
    {
        public float Width { get; private set; }
        public float Height { get; private set; }
        public float Area { get => this.Width * this.Height; }
        public float Perimeter { get => 2f * (this.Width + this.Height); }
        public float Diagonal { get => Sqrt(Pow(this.Width, 2) + Pow(this.Height, 2)); }

        public Rectangle(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }

        public (float, float) GetRandomPoint() =>
            (Randomf.Range(-this.Width, this.Width), Randomf.Range(-this.Height, this.Height));
    }
}
