using System.Windows.Media;
using OOP2.Shared;

namespace Shapes
{
    public class Ellipse : Shape
    {
        private Point TopLeft { get; set; }
        private Point DownRight { get; set; }

        public Ellipse(Point topLeft, Point downRight, Brush bgColor, Brush penColor) : base(bgColor, penColor)
        {
            TopLeft = topLeft;
            DownRight = downRight;
        }

        public float GetWidth() => TopLeft.X - DownRight.X;
        public float GetHight() => TopLeft.Y - DownRight.Y;
        
    }
}