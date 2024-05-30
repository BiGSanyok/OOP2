using OOP2.Shared;
using System.Windows.Media;
using OOP2.Shapes;

namespace OOP2.Faсtories;

public class LineFactory : AbstractFactory
{
    public override AbstractShape CreateShape(Point topLeft, Point downRight, Brush bgColor, Brush penColor, int angle)
    {
       return new Shapes.Line(topLeft, downRight, bgColor, penColor, angle);
    }
}
