namespace TriangleWithDesignPatterns
{
    public class TriangleBuilder
    {
        private double A { get; set; } = -1;
        private double B { get; set; } = -1;
        private double C { get; set; } = -1;
        public ITriangleCalculateStrategy TriangleStrategy { get; }

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

        public Triangle Build()
        {
            if (A <= 0)
                return new Triangle(B, C, TriangleStrategy);
            if (B <= 0)
                return new Triangle(A, C, TriangleStrategy);
            if (C <= 0)
                return new Triangle(A, B, TriangleStrategy);

            return new Triangle(A, B, C, TriangleStrategy);
        }
    }
}