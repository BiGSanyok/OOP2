using OOP2.Shared;
using System;
using System.Windows.Media;


namespace Shapes
{
    class Triangle : AbstractShape
    {
        public Point TopLeft { get; set; }
        public Point DownRight { get; set; }

        public Triangle(Point topLeft, Point downRight, Brush bgColor, Brush penColor)
        : base(bgColor, penColor)
        {
            TopLeft = topLeft;
            DownRight = downRight;
        }

    }
}