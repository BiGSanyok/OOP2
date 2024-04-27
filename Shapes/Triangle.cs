using System;
using System.Drawing;


namespace Shapes
{
    class Triangle : Shape
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }

        public Triangle(Point position, double sideA, double sideB, double sideC, Color color)
        {
            Color = color;
            Position = position;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

    }
}