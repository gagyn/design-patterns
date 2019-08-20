namespace TriangleWithDesignPatterns
{
    public class TriangleBuilder
    {
        public double A { get; private set; } = -1;
        public double B { get; private set; } = -1;
        public double C { get; private set; } = -1;

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
                return new Triangle(B, C);
            if (B <= 0)
                return new Triangle(A,C);
            if (C <= 0)
                return new Triangle(A, B);

            return new Triangle(A, B, C);
        }
    }
}