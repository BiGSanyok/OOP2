using System.Drawing;
using System.Windows.Media;

namespace Shapes
{
    public abstract class Shape(Brush bgColor, Brush penColor)
    {
        
        protected Point Position { get; set; }
        
        
        public void SetPosition(Point newPos)
        {
            Position = newPos;
        }
        
        
        public Point GetPosition()
        {
            return Position;
        }

        public Brush BackgroundColor { get; } = bgColor;
        public Brush PenColor { get; } = penColor;

    }
}