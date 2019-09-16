using System;
using System.Collections.Generic;
using System.Text;
using TriangleWithDesignPatterns.Models;
using TriangleWithDesignPatterns.Strategies;

namespace TriangleWithDesignPatterns.Builders
{
    public class RightTriangleBuilder : TriangleBuilder
    {
        public RightTriangleBuilder(ITriangleCalculateStrategy triangleStrategy) : base(triangleStrategy)
        {
        }

        public new RightTriangleBuilder SetA(double a) => (RightTriangleBuilder)base.SetA(a);
        public new RightTriangleBuilder SetB(double b) => (RightTriangleBuilder)base.SetB(b);
        public new RightTriangleBuilder SetC(double c) => (RightTriangleBuilder)base.SetC(c);

        public new Triangle Build()
        {
            if (A <= 0)
                A = Math.Sqrt(C * C - B * B);
            else if (B <= 0)
                B = Math.Sqrt(C * C - A * A);
            else if (C <= 0)
                C = Math.Sqrt(A * A + B * B);

            if (A < B && B < C)
                return new Triangle(A, B, C, TriangleStrategy);

            throw new ArgumentException("The triangle cannot be a right triangle!");
        }
    }
}
