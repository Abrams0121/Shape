using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shape;

namespace TestsForShape
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NotATriangleTestOutOfRangeCheck()
        {
            Shape.Triangle triangle = new Shape.Triangle(122, 23, 13);

            double expectedValue = double.NaN;
            Assert.AreEqual(expectedValue, triangle.Area);


        }

        [TestMethod]
        public void NormalCheckTriangle()
        {
            Shape.Triangle triangle = new Shape.Triangle(13, 10, 13);

            double expectedValue = 60;
            Assert.AreEqual(expectedValue, Math.Round(triangle.Area));
        }

        [TestMethod]
        public void NotATriangleTestZero()
        {
            Shape.Triangle triangle = new Shape.Triangle(0, 10, 10);

            double expectedValue = 0;
            Assert.AreEqual(expectedValue, triangle.Area);
        }

        [TestMethod]
        public void CheckForRectengularTriangle()
        {
            Shape.Triangle triangle = new Shape.Triangle(5, 12, 13);

            string expectedValue = "Прямоугольный треугольник";
            Assert.AreEqual(expectedValue, triangle.shapeName);
        }


        [TestMethod]
        public void NormalCheckCircle()
        {
            Shape.Circle circle = new Shape.Circle(10);

            double expectedValue = 314;
            Assert.AreEqual(expectedValue, Math.Round(circle.Area));
        }

        [TestMethod]
        public void NotACircleZero()
        {
            Shape.Circle circle = new Shape.Circle(0);

            double expectedValue = 0;
            Assert.AreEqual(expectedValue, circle.Area);
        }
    }
}
