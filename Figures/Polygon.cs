using System;
using System.Linq;

namespace Figures
{
    public class Polygon : IPolygon
    {
        /// <summary>
        /// Creates a polygon with given sides
        /// </summary>
        /// <param name="sides">Every side must be greater than 0</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Polygon(double[] sides)
        {
            if (sides == null)
            {
                throw new ArgumentNullException(nameof(sides));
            }
            if (sides.Length < 3)
            {
                throw new ArgumentException("Polygon has 3 sides minimum", nameof(sides));
            }
            if (!sides.All(side => side > 0))
            {
                throw new ArgumentOutOfRangeException(nameof(sides), "Sides must be greater then 0");
            }
            this.sides = (double[])sides.Clone();
        }

        readonly double[] sides;
        public double[] Sides => (double[])sides.Clone();
        /// <summary>
        /// Sum of the all sides lengths
        /// </summary>
        public double Perimeter => sides.Sum();
        public virtual double Area { get; }
    }
}
