using OOP2.Shared;
using System.Windows.Media;

namespace OOP2.Shapes;


public class Line : AbstractShape
{
    public Line(Point topLeft, Point downRight, Brush bgColor, Brush borderColor, int angle) : base(topLeft, downRight, bgColor, borderColor, angle)
    { }

    public override string ToString() =>
        $"{nameof(Line)}: Start:({TopLeft.X}-{TopLeft.Y}; End:({DownRight.X}-{DownRight.Y})";
}