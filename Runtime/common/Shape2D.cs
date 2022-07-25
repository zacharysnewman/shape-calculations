namespace Shaper.Shapes
{
    public abstract class Shape2D
    {
        public abstract (float, float) GetRandomPoint();

        public (float, float)[] GetRandomPoints(int numberOfPoints)
        {
            var points = new (float, float)[numberOfPoints];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = GetRandomPoint();
            }
            return points;
        }
    }
}

