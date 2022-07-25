namespace Shaper.Shapes
{
	public interface IShape2D
	{
		float Area { get; }
		float Perimeter { get; }
		(float, float) GetRandomPoint();
		//(float, float) GetRandomPoint(bool centered = false);
		(float, float)[] GetRandomPoints(int numberOfPoints);
		//(float, float)[] GetRandomPoints(int numberOfPoints, bool centered = false);
		//(float, float) GetCenterPoint(bool centered = false);
		//(float, float)[] GetPerimeterPoints(int pointDensity, bool centered = false);
	}
}
