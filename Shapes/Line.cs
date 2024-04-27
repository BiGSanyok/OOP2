using OOP2.Shared;
using System.Windows.Media;

namespace Shapes;

public class Line : AbstractShape
{
    public Line(Point topLeft, Point downRight, Brush bgColor, Brush borderColor) : base(topLeft, downRight, bgColor, borderColor)
    { }

    public override string ToString() =>
        $"{nameof(Line)}: Start:({TopLeft.X}-{TopLeft.Y}; End:({DownRight.X}-{DownRight.Y})";
}