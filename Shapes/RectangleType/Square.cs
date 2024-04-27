using OOP2.Shared;
using System.Windows.Media;

namespace OOP2.Shapes.RectangleType;

public class Square : Rectangle
{
    public Square(Point topLeft, Point downRight, Brush backgroundColor, Brush penColor)
       : base(topLeft, downRight, backgroundColor, penColor)
    { }

    public override string ToString() =>
        $"{nameof(Square)}:({TopLeft.X}-{TopLeft.Y}; Side={GetWidth()};";
}