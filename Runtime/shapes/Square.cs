using Shaper.Random;
using static Shaper.Math.Mathf;

namespace Shaper.Shapes
{
    public class Square : Shape2D, IShape2D, IRectangle
    {
        public float Length { get; private set; }
        public float Width { get => this.Length; }
        public float Height { get => this.Length; }
        public float Area { get => this.Length * this.Length; }
        public float Perimeter { get => 4f * this.Length; }
        public float Diagonal { get => this.Length * Sqrt(2); }

        public Square(float length)
        {
            this.Length = length;
        }

        public override (float, float) GetRandomPoint() =>
            (Randomf.Range(-this.Width, this.Width), Randomf.Range(-this.Height, this.Height));
    }
}
