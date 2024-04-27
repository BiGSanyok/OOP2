using System.Drawing;

namespace Shapes
{
    public class Rectangle: Shape
    {
        private double Width { get; set; }
        private double Height { get; set; }

        public Rectangle(Point location, double width, double height, Color color)
        {
            this.Color = color;
            this.Position = location;
            this.Width = width;
            this.Height = height;
        }
        
        public void SetSize(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        public double GetWidth()
        {
            return this.Width;
        }

        public double GetHeight()
        {
            return this.Height;
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color))
            {
                graphics.DrawRectangle(pen, Position.X, Position.Y, (int)Width, (int)Height);
            }
        }
    }
}