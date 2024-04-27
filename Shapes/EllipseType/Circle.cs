using OOP2.Shared;
using System.Windows.Media;

namespace OOP2.Shapes.EllipseType
{
    public class Circle : Ellipse
    {
        public Circle(Point topLeft, Point downRight, Brush bgColor, Brush penColor, int angle) : base(topLeft, downRight, bgColor, penColor, angle) { }
        public override string ToString() => $"{nameof(Circle)}:({TopLeft.X}-{TopLeft.Y}; Radius={GetHeight()};";
    }
}