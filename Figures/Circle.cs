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

        public Circle()
        {
            Radius = 0;
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
                    throw new ArgumentOutOfRangeException(nameof(value), "Radius must be non-negative");
                }
                radius = value;
            }
        }
        public double Diameter => radius * 2;
        /// <summary>
        /// Equals Radius^2 * PI
        /// </summary>
        public double Area => Radius * Radius * Math.PI;
    }
}
