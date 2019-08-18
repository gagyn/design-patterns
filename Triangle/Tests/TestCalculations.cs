using NUnit.Framework;
using TriangleWithDesignPatterns;

namespace Tests
{
    public class TestCalculations
    {
        private Triangle _triangle;
        private Calculable _shape;
        
        [SetUp]
        public void Setup()
        {
            this._triangle = new TriangleBuilder()
                .SetA(3)
                .SetB(4)
                .SetC(5)
                .Build();
            
            this._shape = new Calculable(this._triangle);
        }

        [Test]
        public void TestArea()
        {
            Assert.AreEqual(6, _shape.CalculateArea());
        }

        [Test]
        public void TestPerimeter()
        {
            Assert.AreEqual(12,_shape.CalculatePerimeter());
        }
    }
}