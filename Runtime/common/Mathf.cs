namespace Shaper.Math
{
    public static class Mathf
    {
        public static float PI { get => (float)System.Math.PI; }
        public static float Sqrt(float f) => (float)System.Math.Sqrt(f);
        public static float Pow(float x, float y) => (float)System.Math.Pow(x, y);
        public static float Cos(float f) => (float)System.Math.Cos(f);
        public static float Sin(float f) => (float)System.Math.Sin(f);
        public static float DegToRad(float degrees)
        {
            return degrees * (float)(System.Math.PI / 180.0);
        }
        public static (float, float) VectorSubtract((float, float) a, (float, float) b)
        {
            var (ax, ay) = a;
            var (bx, by) = b;
            return (ax - bx, ay - by);
        }
    }
}
