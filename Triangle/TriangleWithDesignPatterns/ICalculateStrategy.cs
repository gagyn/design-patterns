namespace TriangleWithDesignPatterns
{
    public interface ICalculateStrategy
    {
        double Area(IShape shape);
        double Perimeter(IShape shape);
    }
}