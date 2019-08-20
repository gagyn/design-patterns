namespace TriangleWithDesignPatterns
{
    public class RightTriangleCalculateStrategy : ITriangleCalculateStrategy
    {
        public double Area(Triangle triangle)
        {
            return triangle.A * triangle.B / 2;
        }

        public double Perimeter(Triangle triangle)
        {
            return triangle.A + triangle.B + triangle.C;
        }
    }
}