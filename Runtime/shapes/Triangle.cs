using System;
using ShapeCalculations.Random;
using static ShapeCalculations.Math.Mathf;

namespace ShapeCalculations.Shapes
{
    public class EquilateralTriangle : IRandomPointable
    {
        public float Length { get; private set; }
        public float Height { get => Sqrt(Pow(this.Length, 2) - Pow(this.Length / 2, 2)); }
        public float Area { get => Sqrt(3f) / 4f * this.Length; }
        public float Perimeter { get => this.Length * 3f; }
        public (float, float) P1 { get => (0, 0); }
        public (float, float) P2 { get => (this.Length / 2, this.Height); }
        public (float, float) P3 { get => (this.Length, 0); }

        public EquilateralTriangle(float length)
        {
            this.Length = length;
        }

        // Source: https://blogs.sas.com/content/iml/2020/10/19/random-points-in-triangle.html
        public (float, float) GetRandomPoint()
        {
            var p1 = (0, 0);
            var p2 = (this.Length / 2, this.Height);
            var p3 = (this.Length, 0);
            var a = VectorSubtract(p2, p1);
            var b = VectorSubtract(p3, p1);

            var u1 = Randomf.Range(0f, 1f);
            var u2 = Randomf.Range(0f, 1f);
            if(u1 + u2 > 1)
            {
                u1 = 1 - u1;
                u2 = 1 - u2;
            }
            //var w = u1 * a + u2 * b;
            // patch
            throw new NotImplementedException();
        }
    }
}
