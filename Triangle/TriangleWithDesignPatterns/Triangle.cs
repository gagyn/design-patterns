using System;

namespace TriangleWithDesignPatterns
{
    public class Triangle
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public double Area => this._triangleStrategy.Area(this);
        public double Perimeter => this._triangleStrategy.Perimeter(this);

        private ITriangleCalculateStrategy _triangleStrategy;

        public Triangle(double a, double b, ITriangleCalculateStrategy triangleCalculateStrategy)
        {
            this.A = a;
            this.B = b;
            this.C = Math.Sqrt(this.A + this.B);
            
            CheckArgs();

            this._triangleStrategy = triangleCalculateStrategy;
        }
        
        public Triangle(double a, double b, double c, ITriangleCalculateStrategy triangleCalculateStrategy)
        {
            this.A = a;
            this.B = b;
            this.C = c;

            CheckArgs();

            this._triangleStrategy = triangleCalculateStrategy;
        }

        private void CheckArgs()
        {
            if (CheckIfTriangleCanExist() == false || CheckIfAllArgsAreBiggerThan0() == false)
                throw new ArgumentException("This triangle cannot exist.");
        }

        private bool CheckIfAllArgsAreBiggerThan0()
            => A > 0 && B > 0 && C > 0;

        private bool CheckIfTriangleCanExist()
        {
            if (A + B <= C)
                return false;
            if (A + C <= B)
                return false;
            if (B + C <= A)
                return false;
            
            return true;
        }

        public override string ToString() => $"A: {A}, B: {B}, C: {C}";
    }
}