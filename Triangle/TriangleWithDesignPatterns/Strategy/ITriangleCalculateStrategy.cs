namespace TriangleWithDesignPatterns
{
    public interface ITriangleCalculateStrategy
    {
        double CalculateArea(Triangle triangle);
        double CalculatePerimeter(Triangle triangle);
    }
}