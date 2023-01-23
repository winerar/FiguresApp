using System;
using System.Linq;

namespace Figures
{
    public class Polygon : IPolygon
    {
        public Polygon(int sidesCount)
        {
            sides = new double[sidesCount];
        }
        readonly double[] sides;
        public double[] Sides => sides;
        public double Perimeter => Sides.Sum();
        public virtual double Area { get; }
    }
}
