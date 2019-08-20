namespace TriangleWithDesignPatterns
{
    public interface ITriangleCalculateStrategy
    {
        double Area(Triangle triangle);
        double Perimeter(Triangle triangle);
    }
}