namespace TriangleWithDesignPatterns
{
    public class TriangleBuilder
    {
        public double A { get; private set; } = -1;
        public double B { get; private set; } = -1;
        public double C { get; private set; } = -1;

        public TriangleBuilder()
        {
        }

        public TriangleBuilder SetA(int A)
        {
            this.A = A;
            return this;
        }

        public TriangleBuilder SetB(int B)
        {
            this.B = B;
            return this;
        }
        
        public TriangleBuilder SetC(int C)
        {
            this.C = C;
            return this;
        }

        public Triangle Build() => new Triangle(A, B, C);
    }
}