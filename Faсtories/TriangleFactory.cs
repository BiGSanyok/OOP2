using OOP2.Shared;
using OOP2.Shapes;
using System.Windows.Media;

namespace OOP2.Faсtories;

public class TriangleFactory : AbstractFactory
{
    public override AbstractShape CreateShape(Point topLeft, Point downRight, Brush bgColor, Brush penColor, int angle)
    {
        return new Triangle(topLeft, downRight, bgColor, penColor, angle);
    }
}
