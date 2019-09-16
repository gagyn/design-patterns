namespace TriangleWithDesignPatterns
{
    public class RightTriangleCalculateStrategy : ITriangleCalculateStrategy
    {
        public double CalculateArea(Triangle triangle)
        {
            return triangle.A * triangle.B / 2;
        }

        public double CalculatePerimeter(Triangle triangle)
        {
            return triangle.A + triangle.B + triangle.C;
        }
    }
}