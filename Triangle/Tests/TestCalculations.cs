using System;
using System.Collections.Generic;
using NUnit.Framework;
using TriangleWithDesignPatterns;

namespace Tests
{
    public class TestCalculations
    {
        private readonly double[] _areas = {
            6, 24, 3.8971143170299739104367542683882
        };

        private readonly double[] _perimeters = {
            12, 24, 9
        };
        
        private List<Triangle> _triangles;

        [SetUp]
        public void Setup()
        {
            _triangles = new List<Triangle>
            {
                new TriangleBuilder(new RightTriangleCalculateStrategy())
                    .SetA(3)
                    .SetB(4)
                    .SetC(5)
                    .Build(),
                new TriangleBuilder(new RightTriangleCalculateStrategy())
                    .SetA(6)
                    .SetB(8)
                    .SetC(10)
                    .Build(),
                new TriangleBuilder(new TriangleCalculateStrategy())
                    .SetA(3)
                    .SetB(3)
                    .SetC(3)
                    .Build()
            };
        }

        [Test]
        public void TestArea()
        {
            for (var i = 0; i < _triangles.Count; i++)
            {
                var triangle = _triangles[i];
                Assert.AreEqual(this._areas[i], triangle.Area);
            }
        }

        [Test]
        public void TestPerimeter()
        {
            for (var i = 0; i < _triangles.Count; i++)
            {
                var triangle = _triangles[i];
                Assert.AreEqual(this._perimeters[i], triangle.Perimeter);
            }
        }

        [Test]
        public void TestRightTriangle()
        {
            var triangle = new TriangleBuilder(new RightTriangleCalculateStrategy()).SetA(8).SetB(6).Build();
            
            Assert.AreEqual(24, triangle.Area);
        }

        [Test]
        public void WrongTriangle()
        {
            var trB = new TriangleBuilder(new TriangleCalculateStrategy()).SetA(59).SetB(30).SetC(100);
            
            Assert.Throws<ArgumentException>(() => trB.Build());
        }
    }
}