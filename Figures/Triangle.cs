namespace Figures
{
    public class Triangle : Polygon
    {
        public Triangle(double a, double b, double c) : base(new double[]{ a, b, c })
        {
            if (!TriangleIsValid(a, b, c))
            {
                throw new ArgumentException("Sum of two sides must be greater than third side");
            }
        }

        private static bool TriangleIsValid(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public double A => Sides[0];
        public double B => Sides[1];
        public double C => Sides[2];
        double semiPerimeter => Perimeter / 2;

        public bool IsRight
        {
            get
            {
                double[] orderedSides = new double[Sides.Length];
                Array.Copy(Sides, orderedSides, Sides.Length);
                Array.Sort(orderedSides);
                return orderedSides[0] * orderedSides[0] + orderedSides[1] * orderedSides[1] == orderedSides[2] * orderedSides[2];
            }
        }

        public override double Area => Math.Sqrt(semiPerimeter * 
            (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
    }
}