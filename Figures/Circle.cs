using System;
using System.Linq;

namespace Figures
{
    public class Circle : IFigure
    {
        /// <summary>
        /// Create a new circle
        /// </summary>
        /// <param name="radius">Must be be non-negative</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        double radius;
        /// <summary>
        /// Must be non-negative
        /// </summary>
        public double Radius
        {
            get => radius;
            set
            {
                if (value < 0)
                {
                    radius = 0;
                    return;
                }
                radius = value;
            }
        }
        /// <summary>
        /// Must be non-negative
        /// </summary>
        public double Diameter
        {
            get => radius * 2;
            set
            {
                Radius = value / 2;
            }
        }
        /// <summary>
        /// Equals Radius^2 * PI
        /// </summary>
        public double Area => Radius * Radius * Math.PI;
    }
}
