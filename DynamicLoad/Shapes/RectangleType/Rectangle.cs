using System.Windows.Media;
using OOP2.Shared;
using OOP2.Strategies;

namespace OOP2.Shapes.RectangleType;

public class Rectangle : AbstractShape
{
    public override object Tag => "2";

    public Rectangle(Point topLeft, Point downRight, Brush bgColor, Brush penColor, int angle)
        : base(topLeft, downRight, bgColor, penColor, angle) => DrawStrategy = new RectangleDrawStrategy();
    public virtual double GetHeight() => Math.Abs(TopLeft.Y - DownRight.Y);
    public virtual double GetWidth() => Math.Abs(TopLeft.X - DownRight.X);
}