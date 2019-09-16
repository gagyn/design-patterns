using System;

namespace TriangleWithDesignPatterns
{
    public class Triangle
    {
        public double A { get; protected set; }
        public double B { get; protected set; }
        public double C { get; protected set; }

        public double Area => this._triangleStrategy.CalculateArea(this);
        public double Perimeter => this._triangleStrategy.CalculatePerimeter(this);

        protected ITriangleCalculateStrategy _triangleStrategy;

        protected Triangle(double a, double b, ITriangleCalculateStrategy triangleCalculateStrategy)
        {
            this.A = a;
            this.B = b;

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

        public void SetNewStrategy(ITriangleCalculateStrategy calculateStrategy) 
            => this._triangleStrategy = calculateStrategy;

        public override string ToString() => $"A: {A}, B: {B}, C: {C}";

        protected void CheckArgs()
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
    }
}