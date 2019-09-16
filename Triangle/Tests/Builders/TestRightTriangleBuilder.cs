using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TriangleWithDesignPatterns;
using TriangleWithDesignPatterns.Builder;

namespace Tests.Builders
{
    class TestRightTriangleBuilder : ITestTriangleBuilder
    {
        [Test]
        public void TestTriangleBuildingProcess()
        {
            Assert.DoesNotThrow(
                () => _ = new RightTriangleBuilder(new RightTriangleCalculateStrategy()).SetA(3).SetB(4).SetC(5).Build());

            Assert.DoesNotThrow(
                () => _ = new RightTriangleBuilder(new RightTriangleCalculateStrategy()).SetA(4).SetB(5).SetC(6.4031242374328).Build());

            Assert.DoesNotThrow(
                () => _ = new RightTriangleBuilder(new RightTriangleCalculateStrategy()).SetA(4).SetB(5).Build());

            Assert.DoesNotThrow(
                () => _ = new RightTriangleBuilder(new RightTriangleCalculateStrategy()).SetB(4).SetC(5).Build());
        }

        [Test]
        public void TestTriangleFailedBuildingProcess()
        {
            Assert.Throws<ArgumentException>(
                () => _ = new RightTriangleBuilder(new RightTriangleCalculateStrategy()).SetA(1).SetB(4).SetC(1).Build());
            
            Assert.Throws<ArgumentException>(
                () => _ = new RightTriangleBuilder(new RightTriangleCalculateStrategy()).SetA(3).SetB(5).SetC(4).Build());

            Assert.Throws<ArgumentException>(
                () => _ = new RightTriangleBuilder(new RightTriangleCalculateStrategy()).Build());
        }
    }
}
