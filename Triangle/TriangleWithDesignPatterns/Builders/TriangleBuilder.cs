using TriangleWithDesignPatterns.Models;
using TriangleWithDesignPatterns.Strategies;

namespace TriangleWithDesignPatterns.Builders
{
    public class TriangleBuilder
    {
        protected double A { get; set; } = -1;
        protected double B { get; set; } = -1;
        protected double C { get; set; } = -1;
        protected ITriangleCalculateStrategy TriangleStrategy { get; }

        public TriangleBuilder(ITriangleCalculateStrategy triangleStrategy)
        {
            this.TriangleStrategy = triangleStrategy;
        }

        public TriangleBuilder SetA(double A)
        {
            this.A = A;
            return this;
        }

        public TriangleBuilder SetB(double B)
        {
            this.B = B;
            return this;
        }
        
        public TriangleBuilder SetC(double C)
        {
            this.C = C;
            return this;
        }

        public Triangle Build() => new Triangle(this.A, this.B, this.C, TriangleStrategy);
    }
}