using System;
using Shaper.Random;
using static Shaper.Math.Mathf;

namespace Shaper.Shapes
{
    public class Hexagon
    {
        public float Circumradius { get; private set; }

        public Hexagon(float circumradius)
        {
            Circumradius = circumradius;
        }

        public float Area => 3 * Sqrt(3) / 2 * Circumradius * Circumradius;

        public float Perimeter => 6 * Circumradius * Sin(PI / 3);

        public float Width => 2 * Circumradius;

        public float Height => Sqrt(3) * Circumradius;

        public (float, float, float)[] GetVertices()
        {
            (float, float, float)[] vertices = new (float, float, float)[6]; // 6 vertices

            for (int i = 0; i < 6; i++)
            {
                float angle_deg = 60 * i - 30; // Start at -30 degrees to orient with flat sides on top and bottom
                float angle_rad = DegToRad(angle_deg);
                float x = Circumradius * Cos(angle_rad);
                float y = Circumradius * Sin(angle_rad);
                vertices[i] = (x, y, 0);
            }

            return vertices;
        }
    }
}
