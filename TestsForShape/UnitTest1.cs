using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shape;

namespace TestsForShape
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NormalWorkCheck()
        {
            Shape.Shape.Triangle triangle = new Shape.Shape.Triangle(122,23,13);

            double expectedValue = 0;
            Assert.AreEqual(expectedValue, triangle.Area);


        }
    }
}
