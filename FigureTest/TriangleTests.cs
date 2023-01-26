using Figures;

namespace FigureTests
{
    [TestClass]
    public class TriangleTests
    {
        readonly Triangle triangle = new(5, 5, 8);

        [TestMethod]
        public void AreaIsCorrect()
        {
            Assert.AreEqual(12, triangle.Area);
        }

        [TestMethod]
        public void GetSides()
        {
            Triangle triangle = new(3, 4, 5);
            Assert.AreEqual(3, triangle.A);
            Assert.AreEqual(4, triangle.B);
            Assert.AreEqual(5, triangle.C);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidTriangle()
        {
            Triangle triangle = new(1, 2, 3);
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