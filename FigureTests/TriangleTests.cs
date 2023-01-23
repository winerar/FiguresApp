using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void PerimeterIsCorrect()
        {
            var triangle = new Triangle(3, 4, 5);
            double expected = 12;

            Assert.AreEqual(expected, triangle.Perimeter);
        }
    }
}
