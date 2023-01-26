using Figures;

namespace FigureTests
{
    [TestClass]
    public class PolygonTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullSides()
        {
            Polygon polygon = new(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptySides()
        {
            Polygon polygon = new(new double[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OneSide()
        {
            Polygon polygon = new(new double[] { 1, });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TwoSides()
        {
            Polygon polygon = new(new double[] { 1, 2 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ZeroLength()
        {
            Polygon polygon = new(new double[] { 0, 1, 3, 4 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeLength()
        {
            Polygon polygon = new(new double[] { 1, 3, -5, 7 });
        }

        [TestMethod]
        public void GetSides()
        {
            Polygon polygon = new(new double[] { 3, 5, 7, 9 });

            CollectionAssert.AreEqual(new double[] { 3, 5, 7, 9 }, polygon.Sides);
        }

        [TestMethod]
        public void Perimeter()
        {
            Polygon polygon = new(new double[] { 3, 5, 7, 9, 12});

            Assert.AreEqual(36, polygon.Perimeter);
        }

        [TestMethod]
        public void ImpossibleToChangeSides()
        {
            Polygon polygon = new(new double[] { 3, 5, 7, 9 });
            polygon.Sides[0] = 100;
            polygon.Sides[1] = 200;

            CollectionAssert.AreEqual(new double[] { 3, 5, 7, 9 }, polygon.Sides);
        }
    }
}
