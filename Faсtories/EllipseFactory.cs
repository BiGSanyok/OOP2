using OOP2.Shared;
using System.Windows.Media;
using OOP2.Shapes.EllipseType;

namespace OOP2.Faсtories;

public class EllipseFactory : AbstractFactory
{
    public override AbstractShape CreateShape(Point topLeft, Point downRight, Brush bgColor, Brush penColor, int angle)
    {
        return new Ellipse(topLeft, downRight, bgColor, penColor, angle);
    }
}
