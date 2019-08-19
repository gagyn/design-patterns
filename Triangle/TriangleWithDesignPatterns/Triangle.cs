using System;

namespace TriangleWithDesignPatterns
{
    public class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            
            if (CheckIfAllArgsAreBiggerThan0() == false)
                throw new ArgumentNullException();

            if (CheckIfTriangleCanExist() == false)
                throw new ArgumentException("This triangle cannot exist.");
        }

        private bool CheckIfAllArgsAreBiggerThan0()
            => A > 0 && B > 0 && C > 0;

        private bool CheckIfTriangleCanExist()
        {
            if (A + B < C)
                return false;
            if (A + C < B)
                return false;
            if (B + C < A)
                return false;
            
            return true;
        }

        public override string ToString() => $"A: {A}, B: {B}, C: {C}";
    }
}