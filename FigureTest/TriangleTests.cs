using Figures;

namespace FigureTests
{
    [TestClass]
    public class TriangleTests
    {
        readonly Triangle triangle = new(5, 5, 8);

        [TestMethod]
        public void PerimeterIsCorrect()
        {
            Assert.AreEqual(18, triangle.Perimeter);
        }

        [TestMethod]
        public void AreaIsCorrect()
        {
            Assert.AreEqual(12, triangle.Area);
        }

        [TestMethod]
        public void Sides()
        {
            Triangle triangle = new(1, 2, 3);
            Assert.AreEqual(1, triangle.A);
            Assert.AreEqual(2, triangle.B);
            Assert.AreEqual(3, triangle.C);
        }

        [TestMethod]
        public void TriangleIsRight()
        {
            var rightTriangle = new Triangle(3, 4, 5);

            Assert.IsTrue(rightTriangle.IsRight);
        }

        [TestMethod]
        public void TriangleIsNotRight()
        {
            Assert.IsFalse(triangle.IsRight);
        }
    }
}