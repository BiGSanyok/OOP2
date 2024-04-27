using System.Windows.Media;
using OOP2.Shared;
using Shapes;

namespace OOP2.Shapes.RectangleType;

public class Rectangle : AbstractShape
{
    public Rectangle(Point topLeft, Point downRight, Brush bgColor, Brush penColor) : base(topLeft, downRight, bgColor, penColor) { }
    public double GetHeight() => Math.Abs(TopLeft.Y - DownRight.Y);
    public double GetWidth() => Math.Abs(TopLeft.X - DownRight.X);
}