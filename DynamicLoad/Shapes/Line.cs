using OOP2.Shared;
using System.Windows.Media;
using OOP2.Strategies;

namespace OOP2.Shapes;


public class Line : AbstractShape
{
    public override object Tag => "4";

    public Line(Point topLeft, Point downRight, Brush bgColor, Brush borderColor, int angle) : base(topLeft, downRight,
        bgColor, borderColor, angle)
        => DrawStrategy = new LineDrawStrategy();

    public override string ToString() =>
        $"{nameof(Line)}: Start:({TopLeft.X}-{TopLeft.Y}; End:({DownRight.X}-{DownRight.Y})";
}