using Figures;

namespace FigureTests
{
    [TestClass]
    public class CircleTests
    {
        readonly Circle circle = new(2);

        [TestMethod]
        public void AreaIsCorrect()
        {
            Assert.AreEqual(4 * Math.PI, circle.Area);
        }

        [TestMethod]
        public void DiameterIsCorrect()
        {
            Assert.AreEqual(4, circle.Diameter);
        }

        [TestMethod]
        public void SetRadius()
        {
            Circle circle = new(1);
            circle.Radius = 2;

            Assert.AreEqual(2, circle.Radius);
        }

        [TestMethod]
        public void SetDiameter()
        {
            Circle circle = new(1);
            circle.Diameter = 4;

            Assert.AreEqual(2, circle.Radius);
        }

        [TestMethod]
        public void SetNegativeRadius()
        {
            Circle circle = new(1);
            circle.Radius = -10;

            Assert.AreEqual(0, circle.Radius);
        }
    }
}
