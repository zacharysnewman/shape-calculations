namespace Shaper.Shapes
{
    public interface IRectangle
    {
        public float Width { get; }
        public float Height { get; }
        public float Area { get; }
        public float Perimeter { get; }
        public float Diagonal { get; }
    }
}