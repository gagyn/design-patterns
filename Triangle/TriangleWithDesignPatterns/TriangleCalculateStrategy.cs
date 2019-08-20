using System;

namespace TriangleWithDesignPatterns
{
    public class TriangleCalculateStrategy : ITriangleCalculateStrategy
    {
        public double Area(Triangle triangle)
        {
            double s1 = triangle.A + triangle.B + triangle.C;
            double s2 = triangle.A + triangle.B - triangle.C;
            double s3 = triangle.A - triangle.B + triangle.C;
            double s4 = -triangle.A + triangle.B + triangle.C;

            return Math.Sqrt(s1 * s2 * s3 * s4) / 4.0;
        }

        public double Perimeter(Triangle triangle)
        {
            return triangle.A + triangle.B + triangle.C;
        }
    }
}