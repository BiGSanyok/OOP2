using System.Drawing;

namespace Shapes
{
    public class Square : Shape
    {
        private double SideLength { get; set; }

        public Square(Point position, double size, Color color)
        {
            SideLength = size;
            Color = color;
            Position = position;
        }

        public void SetSideSize(double newSize)
        {
            SideLength = newSize;
        }

        public double GetSideSize()
        {
            return SideLength;
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color))
            {
                graphics.DrawRectangle(pen, Position.X, Position.Y, (int)SideLength, (int)SideLength);
            }
        }
    }
}