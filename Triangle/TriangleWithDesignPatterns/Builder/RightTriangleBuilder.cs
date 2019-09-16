using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleWithDesignPatterns.Builder
{
    public class RightTriangleBuilder : TriangleBuilder
    {
        public RightTriangleBuilder(ITriangleCalculateStrategy triangleStrategy) : base(triangleStrategy)
        {
        }

        public new Triangle Build()
        {
            if (A <= 0)
                return new RightTriangle(B, C, TriangleStrategy);
            if (B <= 0)
                return new RightTriangle(A, C, TriangleStrategy);
            if (C <= 0)
                return new RightTriangle(A, B, TriangleStrategy);

            return new RightTriangle(A, B, C, TriangleStrategy);
        }
    }
}
