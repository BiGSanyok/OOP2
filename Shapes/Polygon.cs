using System.Collections.Generic;
using System.Drawing;

namespace Shapes
{
    public class Polygon : Shape
    {
        private List<Point> Points { get; set; }
    
        public Polygon(Point location, List<Point> points, Color color)
        {
            Color = color;
            Position = location;
            Points = points;
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color))
            {
                graphics.DrawPolygon(pen, Points.ToArray());
            }
        }
    }
}