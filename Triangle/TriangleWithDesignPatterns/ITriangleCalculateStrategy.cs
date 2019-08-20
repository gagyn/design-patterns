namespace TriangleWithDesignPatterns
{
    public interface ITriangleCalculateStrategy
    {
        double Area(Triangle shape);
        double Perimeter(Triangle shape);
    }
}