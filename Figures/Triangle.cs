namespace Figures
{
    public class Triangle : Polygon
    {
        public Triangle(double a, double b, double c) : base(3)
        {
            Sides[0] = a;
            Sides[1] = b;
            Sides[2] = c;
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