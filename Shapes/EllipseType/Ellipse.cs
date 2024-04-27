using System.Windows.Media;
using OOP2.Shared;

namespace OOP2.Shapes.EllipseType;

public class Ellipse : AbstractShape
{
    public Ellipse(Point topLeft, Point downRight, Brush bgColor, Brush penColor, int angle) : base(topLeft, downRight, bgColor, penColor, angle)
    { }

    public double GetWidth() => Math.Abs(TopLeft.X - DownRight.X);
    public double GetHeight() => Math.Abs(TopLeft.Y - DownRight.Y);
    public override string ToString() => $"{nameof(Ellipse)}:({TopLeft.X}-{TopLeft.Y}; Width={GetWidth()}; Height={GetHeight}";
}