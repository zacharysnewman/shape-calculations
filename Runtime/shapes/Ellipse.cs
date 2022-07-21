using Shaper.Random;
using static Shaper.Math.Mathf;

namespace Shaper.Shapes
{
    public class Ellipse : IRandomPointable
    {
        public float RadiusWidth { get; private set; }
        public float RadiusHeight { get; private set; }
        public float Area { get => PI * this.RadiusWidth * this.RadiusHeight; }
        public float ApproximatePerimeter { get => 2f * PI * Sqrt(Pow(this.RadiusWidth, 2) + Pow(this.RadiusHeight, 2) / 2); }
        public float Eccentricity { get => (Sqrt(Pow(this.RadiusWidth, 2) - Pow(this.RadiusHeight, 2))) / this.RadiusWidth; }

        public Ellipse(float radiusWidth, float radiusHeight)
        {
            this.RadiusWidth = radiusWidth;
            this.RadiusHeight = radiusHeight;
        }

        public (float, float) GetRandomPoint()
        {
            // Get Angle in radians
            float theta = 2 * PI * Randomf.Range(0f, 1f);

            // Get length from center
            float len = Sqrt(Randomf.Range(0f, 1f));

            // Add point to results.
            float xPos = len * Cos(theta) * this.RadiusWidth;
            float yPos = len * Sin(theta) * this.RadiusHeight;
            return (xPos, yPos);
        }
    }
}
