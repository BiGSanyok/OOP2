using System.Text.Json.Serialization;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using OOP2.Interfaces;

namespace OOP2.Shared
{
    public abstract class AbstractShape(Brush bgColor, Brush penColor)
    {
        [JsonIgnore]
        public static Canvas Canvas { get; set; }
        public virtual object Tag { get;  }
        public int CanvasIndex { get; set; }
        public int Angle { get; set; }
        public int CornerOXY { get; private set; }
        public double StrokeThickness { get; set; } = 1;
        public Point TopLeft { get; protected set; }
        public Point DownRight { get; protected set; }
        public Brush BackgroundColor { get;  set; } = bgColor;
        public Brush PenColor { get;  set; } = penColor;

        public IDrawStrategy DrawStrategy { get; protected set; }

        public AbstractShape(Point topLeft, Point downRight, Brush bgColor, Brush penColor, int angle) : this(bgColor, penColor)
        {
            CanvasIndex = -1;
            TopLeft = topLeft;
            DownRight = downRight;
            Angle = angle;
            CalculateOXY();
        }

        public void CalculateOXY()
        {
            if (DownRight.X > TopLeft.Y)
            {
                CornerOXY = DownRight.Y > TopLeft.Y ? 4 : 1;
            }
            else
            {
                CornerOXY = DownRight.Y > TopLeft.Y ? 3 : 2;    
            }
        }

        public void DrawAlgorithm()
        {
            Shape drawnShape = DrawStrategy.Draw(this);
            if (drawnShape != null)
            {
                if (CanvasIndex < 0)
                {
                    CanvasIndex = Canvas.Children.Count;
                    Canvas.Children.Add(drawnShape);
                }
                else if (Canvas.Children.Count > 0 && CanvasIndex < Canvas.Children.Count)
                {
                    Canvas.Children.RemoveAt(CanvasIndex);
                    Canvas.Children.Insert(CanvasIndex, drawnShape);
                }
                else
                {
                    CanvasIndex = Canvas.Children.Count;
                    Canvas.Children.Add(drawnShape);
                }
                drawnShape.Tag = CanvasIndex;
            }
        }
    }
}
