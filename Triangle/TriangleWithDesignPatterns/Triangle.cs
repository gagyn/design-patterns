using System;

namespace TriangleWithDesignPatterns
{
    public class Triangle : ICalculable
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(TriangleBuilder builder)
        {
            if (CheckIfAllPropertiesHasValue(builder.A, builder.B, builder.C) == false)
                throw new ArgumentNullException();
            
            this.A = (double) builder.A;
            this.B = (double) builder.B;
            this.C = (double) builder.C;
            
            if (CheckIfTriangleCanExist() == false)
                throw new ArgumentException("This triangle cannot exist.");
        }

        private bool CheckIfAllPropertiesHasValue(double? a, double? b, double? c) 
            => a != null && b != null && c != null;

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
        
        public double Area()
        {
            double s1 = A + B + C;
            double s2 = A + B - C;
            double s3 = A - B + C;
            double s4 = -A + B + C;

            return Math.Sqrt(s1 * s2 * s3 * s4) / 4;
        }

        public double Perimeter()
        {
            return A + B + C;
        }
    }
}