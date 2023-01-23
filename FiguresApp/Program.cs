using Figures;

var figures = new List<IFigure>()
{
    new Triangle(3, 4, 5),
    new Circle(10),
};

figures.ForEach(figure => Console.WriteLine($"Area equals {figure.Area}"));

Console.WriteLine();

Console.WriteLine($"Is triangle (3, 4, 5) is right: {(figures[0] as Triangle)?.IsRight}");
