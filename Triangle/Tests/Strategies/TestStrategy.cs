using System.Collections.Generic;
using NUnit.Framework;
using TriangleWithDesignPatterns.Models;

namespace Tests.Strategies
{
    abstract class TestStrategy
    {
        protected List<(Triangle Triangle, double Area, double Perimeter)> _list;

        [SetUp]
        public abstract void Setup();

        [Test]
        public virtual void TestCalculatingArea()
        {
            foreach (var tuple in _list)
            {
                Assert.AreEqual(tuple.Area, tuple.Triangle.Area, 0.00001);
            }
        }

        [Test]
        public virtual void TestCalculatingPerimeter()
        {
            foreach (var tuple in _list)
            {
                Assert.AreEqual(tuple.Perimeter, tuple.Perimeter, 0.00001);
            }
        }
    }
}
