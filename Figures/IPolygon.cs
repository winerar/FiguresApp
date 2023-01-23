using System;
using System.Linq;

namespace Figures
{
    public interface IPolygon : IFigure
    {
        double[] Sides { get; }
        double Perimeter { get; }
    }
}
