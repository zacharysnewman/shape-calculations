using System;
using Shaper.Random;
using static Shaper.Math.Mathf;

namespace Shaper.Shapes
{
    public class TriangleEquilateral : Shape2D, IShape2D
    {
        public float Length { get; private set; }
        public float Height { get => Sqrt(Pow(this.Length, 2) - Pow(this.Length / 2, 2)); }
        public float Area { get => Sqrt(3f) / 4f * this.Length; }
        public float Perimeter { get => this.Length * 3f; }
        public (float, float) A { get => (0, 0); }
		public (float, float) B { get => (this.Length, 0); }
		public (float, float) C { get => (this.Length/2, this.Height); }

        public TriangleEquilateral(float length)
        {
            this.Length = length;
        }

        // Source: https://math.stackexchange.com/questions/3537762/random-point-in-a-triangle
        public override (float, float) GetRandomPoint()
        {
            var(Cx, Cy) = this.C;
			var r1 = Randomf.Range(0f,1f);
			var r2 = Randomf.Range(0f,1f);

			// if over the diagonal, then flip r1 & r2
			if (r1 + r2 > 1) {
				r1 = (1 - r1);
				r2 = (1 - r2);
			}

			var x = this.Length * r2 + Cx * r1;
			var y = Cy * r1;
			return (x, -y);
        }
    }
}
