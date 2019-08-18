namespace TriangleWithDesignPatterns
{
    public class Calculable
    {
        private readonly ICalculable _shape;

        public Calculable(ICalculable shape) => this._shape = shape;

        public double CalculateArea() => _shape.Area();
        public double CalculatePerimeter() => _shape.Perimeter();

        public override string ToString()
        {
            return _shape.ToString();
        }
    }
}