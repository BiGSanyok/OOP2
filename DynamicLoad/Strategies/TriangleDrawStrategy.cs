using OOP2.Shapes;
using OOP2.Shared;
using OOP2.Interfaces;
using System.Windows.Media;
using System.Windows.Shapes;


namespace OOP2.Strategy;

public class TriangleDrawStrategy : IDrawStrategy
{
    public Shape? Draw(AbstractShape shape)
    {

        if (shape is Triangle newTriangle)
        {
            double centerX = (newTriangle.TopLeft.X + newTriangle.VertexOX.X + newTriangle.VertexOY.X) / 3;
            double centerY = (newTriangle.TopLeft.Y + newTriangle.VertexOX.Y + newTriangle.VertexOY.Y) / 3;

            Polygon polygon = new()
            {
                Fill = newTriangle.BackgroundColor,
                Stroke = newTriangle.PenColor,
                Points =
                {
                    new System.Windows.Point(newTriangle.TopLeft.X, newTriangle.TopLeft.Y),
                    new System.Windows.Point(newTriangle.VertexOX.X, newTriangle.VertexOX.Y),
                    new System.Windows.Point(newTriangle.VertexOY.X, newTriangle.VertexOY.Y),
                },
                RenderTransform = new RotateTransform(newTriangle.Angle, centerX, centerY),
                StrokeThickness = newTriangle.StrokeThickness,
            };

            return polygon;
        }

        return null;

    }
}