namespace Shaper.Shapes
{
    public interface IEllipse
    {
        float RadiusWidth { get; }
        float RadiusHeight { get; }
        float Area { get; }
        float Eccentricity { get; }
        public float Perimeter { get; }
    }
}
