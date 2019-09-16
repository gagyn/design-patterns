using System;

namespace TriangleWithDesignPatterns
{
    internal class RightTriangle : Triangle
    {
        public RightTriangle(double a, double b, ITriangleCalculateStrategy triangleCalculateStrategy)
            : base(a, b, Math.Sqrt(a + b), triangleCalculateStrategy)
        {
        }

        public RightTriangle(double a, double b, double c, ITriangleCalculateStrategy triangleCalculateStrategy) 
            : base(a, b, c, triangleCalculateStrategy)
        {
        }
    }
}