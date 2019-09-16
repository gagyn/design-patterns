using System.Collections.Generic;
using NUnit.Framework;
using TriangleWithDesignPatterns;

namespace Tests
{
    internal class TestStrategyCalculations
    {
        /// <summary>
        ///   Triangles, Areas, Perimeters
        /// </summary>
        private List<(Triangle Triangle, double Area, double Perimeter)> _list;

        [SetUp]
        public void Setup()
        {
            var builder = new TriangleBuilder(new TriangleCalculateStrategy());

            _list = new List<(Triangle Triangle, double Area, double Perimeter)>
            {
                (builder.SetA(7).SetB(4).SetC(5).Build(), 9.797958, 16.0),
                (builder.SetA(5).SetB(4).SetC(3).Build(), 6, 12.0),
                (builder.SetA(12).SetB(5).SetC(8).Build(), 14.523687, 25.0),
                (builder.SetA(5).SetB(6).SetC(6).Build(), 13.635890, 17.0)
            };
        }

        [Test]
        public void TestCalculatingArea()
        {
            foreach (var tuple in _list)
            {
                Assert.AreEqual(tuple.Area, tuple.Triangle.Area, 0.00001);
            }
        }

        [Test]
        public void TestCalculatingPerimeter()
        {
            foreach (var tuple in _list)
            {
                Assert.AreEqual(tuple.Perimeter, tuple.Triangle.Perimeter);
            }
        }
    }
}