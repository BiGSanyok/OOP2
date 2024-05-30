using System.Windows.Media;
using OOP2.Shared;
using OOP2.Strategies;

namespace OOP2.Shapes.EllipseType;

public class Ellipse : AbstractShape
{
    public override object Tag => "1";
    public Ellipse(Point topLeft, Point downRight, Brush bgColor, Brush penColor, int angle) : base(topLeft, downRight, bgColor, penColor, angle)
    =>  DrawStrategy = new EllipseDrawStrategy();

    public virtual double GetWidth() => Math.Abs(TopLeft.X - DownRight.X);
    public virtual double GetHeight() => Math.Abs(TopLeft.Y - DownRight.Y);
    public override string ToString() => $"{nameof(Ellipse)}:({TopLeft.X}-{TopLeft.Y}; Width={GetWidth()}; Height={GetHeight}";
}