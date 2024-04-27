using OOP2.Shapes.EllipseType;
using OOP2.Shapes.RectangleType;
using OOP2.Shared;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace OOP2.Strategy;

public class RectangleDrawStrategy : IDrawStrategy
{
    public Shape? Draw(AbstractShape shape)
    {
        if (shape is OOP2.Shapes.RectangleType.Rectangle myRectangle)
        {
            System.Windows.Shapes.Rectangle rectangle = new()
            {
                Fill = myRectangle.BackgroundColor,
                Stroke = myRectangle.PenColor,
                Width = myRectangle.GetWidth(),
                Height = myRectangle.GetHeight(),
            };
        
            Canvas.SetLeft(rectangle, myRectangle.TopLeft.X);
            Canvas.SetTop(rectangle, myRectangle.TopLeft.Y);
        
            myRectangle.CalculateOXY();

            var cornerOXY = myRectangle.CornerOXY;
            rectangle.RenderTransform = new RotateTransform(myRectangle.Angle + 90 * (4 - cornerOXY));

            if (cornerOXY is 3 or 1)
            {
                (rectangle.Width, rectangle.Height) = (rectangle.Height, rectangle.Width);
            }
        
            return rectangle;
        }
        return null;
    }
}