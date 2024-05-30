using OOP2.Shared;
using System.Windows.Media;
using OOP2.Strategy;

namespace OOP2.Shapes.EllipseType
{
    public class Circle : Ellipse
    {
        public override object Tag => "0";

        public Circle(Point topLeft, Point downRight, Brush bgColor, Brush penColor, int angle)
            : base(topLeft, downRight, bgColor, penColor, angle)
        {
        }

        public override string ToString() => $"{nameof(Circle)}:({TopLeft.X}-{TopLeft.Y}; Radius={GetHeight()};";

        public override double GetHeight() => Math.Abs(TopLeft.X - DownRight.X);
        public override double GetWidth() => GetHeight();

    }
}