using OOP2.Shared;
using System.Windows.Media;
using OOP2.Shapes.RectangleType;

namespace OOP2.Faсtories;

public class SquareFactory : AbstractFactory
{
    public override AbstractShape CreateShape(Point topLeft, Point downRight, Brush bgColor, Brush penColor, int angle)
    {
        return new Square(topLeft, downRight, bgColor, penColor, angle);
    }
}
