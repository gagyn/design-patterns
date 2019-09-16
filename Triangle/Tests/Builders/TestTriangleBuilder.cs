using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TriangleWithDesignPatterns;
using TriangleWithDesignPatterns.Builder;

namespace Tests.Builders
{
    class TestTriangleBuilder
    {
        [Test]
        public void TestTriangleBuildingProcess()
        {
            Assert.DoesNotThrow(
                () => _ = new TriangleBuilder(new TriangleCalculateStrategy()).SetA(3).SetB(4).SetC(5).Build());

            Assert.DoesNotThrow(
                () => _ = new TriangleBuilder(new TriangleCalculateStrategy()).SetA(5.656).SetB(5).SetC(7).Build());
        }

        [Test]
        public void TestTriangleFailedBuildingProcess()
        {
            Assert.Throws<ArgumentException>(
                () => _ = new TriangleBuilder(new TriangleCalculateStrategy()).SetA(1).SetB(4).SetC(1).Build());

            Assert.Throws<ArgumentException>(
                () => _ = new TriangleBuilder(new TriangleCalculateStrategy()).SetA(1).SetB(4).Build());

            Assert.Throws<ArgumentException>(
                () => _ = new TriangleBuilder(new TriangleCalculateStrategy()).Build());
        }
    }
}
