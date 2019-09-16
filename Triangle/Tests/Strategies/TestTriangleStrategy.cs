using System.Collections.Generic;
using NUnit.Framework;
using TriangleWithDesignPatterns;

namespace Tests.Strategies
{
    internal class TestStrategyCalculations : TestStrategy
    {
        [SetUp]
        public override void Setup()
        {
            var builder = new TriangleBuilder(new TriangleCalculateStrategy());

            base._list = new List<(Triangle Triangle, double Area, double Perimeter)>
            {
                (builder.SetA(7).SetB(4).SetC(5).Build(), 9.797958, 16.0),
                (builder.SetA(5).SetB(4).SetC(3).Build(), 6, 12.0),
                (builder.SetA(12).SetB(5).SetC(8).Build(), 14.523687, 25.0),
                (builder.SetA(5).SetB(6).SetC(6).Build(), 13.635890, 17.0)
            };
        }
    }
}