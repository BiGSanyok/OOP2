using System.Windows.Media;
using OOP2.Shared;

namespace OOP2.Faсtories;
public abstract class AbstractFactory
{
    public abstract AbstractShape CreateShape(Point topLeft, Point downRight, Brush bgColor, Brush penColor);
}