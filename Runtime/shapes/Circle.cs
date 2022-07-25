using System;
using Shaper.Random;
using static Shaper.Math.Mathf;

namespace Shaper.Shapes
{
    public class Circle : Shape2D, IShape2D, IEllipse
    {
        public float Radius { get; private set; }
        public float RadiusWidth { get => this.Radius; }
        public float RadiusHeight { get => this.Radius; }
        public float Diameter { get => 2f * this.Radius; }
        public float Area { get => PI * Pow(this.Radius, 2); }
        public float Eccentricity { get => 0; }
        public float Perimeter { get => 2f * PI * this.Radius; }

        public Circle(float radius)
        {
            this.Radius = radius;
        }

        public override (float, float) GetRandomPoint()
        {
            // Get Angle in radians
            float theta = 2 * PI * Randomf.Range(0f, 1f);

            // Get length from center
            float len = Sqrt(Randomf.Range(0f, 1f));

            // Add point to results.
            float xPos = len * Cos(theta) * this.Radius;
            float yPos = len * Sin(theta) * this.Radius;
            return (xPos, yPos);
        }
    } 
}
