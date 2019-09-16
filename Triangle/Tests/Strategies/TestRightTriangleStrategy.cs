using System.Collections.Generic;
using NUnit.Framework;
using TriangleWithDesignPatterns.Builders;
using TriangleWithDesignPatterns.Models;
using TriangleWithDesignPatterns.Strategies;

namespace Tests.Strategies
{
    class TestRightTriangleStrategy : TestStrategy
    {
        [SetUp]
        public override void Setup()
        {
            var strategy = new RightTriangleCalculateStrategy();

            base._list = new List<(Triangle Triangle, double Area, double Perimeter)>
            {
                (new RightTriangleBuilder(strategy).SetA(3).SetB(4).SetC(5).Build(), 6.0, 12.0),
                (new RightTriangleBuilder(strategy).SetA(1).SetB(4).Build(), 2.0, 9.123105),
                (new RightTriangleBuilder(strategy).SetB(2).SetC(2.236067).Build(), 1.0, 5.236067)
            };
        }
    }
}
