using System;
using System.Drawing;

namespace Shapes
{
    public class Line : Shape
    {
        private double Length { get; set; }
        private double Angle { get; set; }

        public Line(Point position, double length, double angle, Color color)
        {
            Color = color;
            Angle = angle;
            Length = length;
            Position = position;
        }
        
        public void SetLength(double newSize)
        {
            Length = newSize;
        }

        public double GetLength()
        {
            return Length;
        }
        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color))
            {
                int x2 = Position.X + (int)(Length * Math.Cos(Math.PI * -Angle / 180));
                int y2 = Position.Y + (int)(Length * Math.Sin(Math.PI * -Angle / 180));
            
                graphics.DrawLine(pen, Position, new Point(x2, y2));
            }
        }
    }
}