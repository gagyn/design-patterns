using TriangleWithDesignPatterns.Models;

namespace TriangleWithDesignPatterns.Strategies
{
    public interface ITriangleCalculateStrategy
    {
        double CalculateArea(Triangle triangle);
        double CalculatePerimeter(Triangle triangle);
    }
}