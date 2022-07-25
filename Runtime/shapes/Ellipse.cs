using Shaper.Random;
using static Shaper.Math.Mathf;

namespace Shaper.Shapes
{
    public class Ellipse : Shape2D, IShape2D, IEllipse
    {
        public float RadiusWidth { get; private set; }
        public float RadiusHeight { get; private set; }
        public float Area { get => PI * this.RadiusWidth * this.RadiusHeight; }
        public float ApproximatePerimeter { get => 2f * PI * Sqrt(Pow(this.RadiusWidth, 2) + Pow(this.RadiusHeight, 2) / 2); }
        public float Eccentricity { get => (Sqrt(Pow(this.RadiusWidth, 2) - Pow(this.RadiusHeight, 2))) / this.RadiusWidth; }
        /// <summary>
        /// This returns ApproximatePerimeter. It is an approximation of the perimeter, not an exact value.
        /// The perimeter of an Ellipse can't be calculated exactly.
        /// </summary>
        public float Perimeter { get => ApproximatePerimeter; }

        public Ellipse(float radiusWidth, float radiusHeight)
        {
            this.RadiusWidth = radiusWidth;
            this.RadiusHeight = radiusHeight;
        }

        public override (float, float) GetRandomPoint()
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
