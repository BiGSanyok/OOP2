using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using OOP2.Interfaces;
using OOP2.Shared;

namespace OOP2.Strategies;

public class EllipseDrawStrategy : IDrawStrategy
{
    public Shape? Draw(AbstractShape shape)
    {
        if (shape is OOP2.Shapes.EllipseType.Ellipse myEllipse)
        {
            double width = myEllipse.GetWidth();
            double height = myEllipse.GetHeight();

            System.Windows.Shapes.Ellipse ellipse = new System.Windows.Shapes.Ellipse
            {
                Fill = myEllipse.BackgroundColor,
                Stroke = myEllipse.PenColor,
                Width = width,
                Height = height,
                StrokeThickness = myEllipse.StrokeThickness,
            };

            Canvas.SetLeft(ellipse, myEllipse.TopLeft.X);
            Canvas.SetTop(ellipse, myEllipse.TopLeft.Y);

            var cornerOXY = myEllipse.CornerOXY;
            
            ellipse.RenderTransform = new RotateTransform(myEllipse.Angle + 90 * (4 - cornerOXY));
            

            if (cornerOXY is 3 or 1)
            {
                (ellipse.Width, ellipse.Height) = (ellipse.Height, ellipse.Width);
            }

            return ellipse;
        }

        return null;
    }
}