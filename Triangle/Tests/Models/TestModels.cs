using System;
using NUnit.Framework;
using TriangleWithDesignPatterns.Models;
using TriangleWithDesignPatterns.Strategies;

namespace Tests.Models
{
    class TestModels
    {
        [Test]
        public void TestCreatingTriangles()
        {
            Assert.DoesNotThrow(
                () => _ = new Triangle(3, 4, 5, new TriangleCalculateStrategy()));

            Assert.DoesNotThrow(
                () => _ = new Triangle(5.656, 7, 5, new TriangleCalculateStrategy()));
        }

        [Test]
        public void TestFailedCreatingTriangles()
        {
            Assert.Throws<ArgumentException>(
                () => _ = new Triangle(5, 1, 1, new TriangleCalculateStrategy()));
        }
    }
}
