namespace Shaper.Random
{
    public static class Randomf
    {
        public static float Range(float min, float max)
        {
            System.Random rand = new System.Random();
            float range = max - min;
            double sample = rand.NextDouble();
            double scaled = (sample * range) + min;
            return (float)scaled;
        }
    }
}
