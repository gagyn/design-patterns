using NUnit.Framework;
using TriangleWithDesignPatterns;

namespace Tests
{
    public class TestCalculations
    {
        private Triangle _triangle;
        private TriangleCalculateStrategy _triangleCalculate;
        
        [SetUp]
        public void Setup()
        {
            this._triangle = new TriangleBuilder()
                .SetA(3)
                .SetB(4)
                .SetC(5)
                .Build();
            
            this._triangleCalculate = new TriangleCalculateStrategy();
        }

        [Test]
        public void TestArea()
        {
            Assert.AreEqual(6, _triangleCalculate.Area(_triangle));
        }

        [Test]
        public void TestPerimeter()
        {
            Assert.AreEqual(12,_triangleCalculate.Perimeter(_triangle));
        }
    }
}