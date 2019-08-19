using System;

namespace TriangleWithDesignPatterns
{
    public class TriangleCalculateStrategy : ICalculateStrategy
    {
        public double Area(IShape shape)
        {
            var t = (Triangle) shape;
            
            double s1 = t.A + t.B + t.C;
            double s2 = t.A + t.B - t.C;
            double s3 = t.A - t.B + t.C;
            double s4 = -t.A + t.B + t.C;

            return Math.Sqrt(s1 * s2 * s3 * s4) / 4;
        }

        public double Perimeter(IShape shape)
        {
            var t = (Triangle) shape;
            return t.A + t.B + t.C;
        }
    }
}