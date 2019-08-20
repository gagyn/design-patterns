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
        private TriangleCalculateStrategy _triangleCalculate;
        
        [SetUp]
        public void Setup()
        {
            _triangles = new List<Triangle>
            {
                new TriangleBuilder()
                    .SetA(3)
                    .SetB(4)
                    .SetC(5)
                    .Build(),
                new TriangleBuilder()
                    .SetA(6)
                    .SetB(8)
                    .SetC(10)
                    .Build(),
                new TriangleBuilder()
                    .SetA(3)
                    .SetB(3)
                    .SetC(3)
                    .Build()
            };

            _triangleCalculate = new TriangleCalculateStrategy();
        }

        [Test]
        public void TestArea()
        {
            for (var i = 0; i < _triangles.Count; i++)
            {
                var triangle = _triangles[i];
                Assert.AreEqual(this._areas[i], _triangleCalculate.Area(triangle));
            }
        }

        [Test]
        public void TestPerimeter()
        {
            for (var i = 0; i < _triangles.Count; i++)
            {
                var triangle = _triangles[i];
                Assert.AreEqual(this._perimeters[i], _triangleCalculate.Perimeter(triangle));
            }
        }

        [Test]
        public void TestRightTriangle()
        {
            var rts = new RightTriangleCalculateStrategy();
            var triangle = new TriangleBuilder().SetA(8).SetB(6).Build();
            
            Assert.AreEqual(24, rts.Area(triangle));
        }

        [Test]
        public void WrongTriangle()
        {
            var trB = new TriangleBuilder().SetA(59).SetB(30).SetC(100);
            
            Assert.Throws<ArgumentException>(() => trB.Build());
        }
    }
}