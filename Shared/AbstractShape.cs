using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace OOP2.Shared
{
    public abstract class AbstractShape(Brush bgColor, Brush penColor)
    {
        private int CanvasIndex = -1;

        public Point TopLeft { get; protected set; }
        public Point DownRight { get; protected set; }
        public Brush BackgroundColor { get; } = bgColor;
        public Brush PenColor { get; } = penColor;

        public IDrawStrategy DrawStrategy { get; protected set; }

        public AbstractShape(Point topLeft, Point downRight, Brush bgColor, Brush penColor) : this(bgColor, penColor)
        {
            TopLeft = topLeft;
            DownRight = downRight;
        }

        public void DrawAlgorithm(Canvas canvas)
        {
            Shape drawnShape = DrawStrategy.Draw(this);
            if (drawnShape != null)
            {
                if (CanvasIndex < 0)
                {
                    CanvasIndex = canvas.Children.Count;
                    canvas.Children.Add(drawnShape);
                }
                else
                {
                    canvas.Children.RemoveAt(CanvasIndex);
                    canvas.Children.Insert(CanvasIndex, drawnShape);
                }
                drawnShape.Tag = CanvasIndex;
            }
        }
    }
}
