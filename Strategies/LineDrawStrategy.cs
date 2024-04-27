using System.Windows.Controls;
using OOP2.Shared;
using System.Windows.Shapes;
using OOP2.Shapes;

namespace OOP2.Strategy;

public class LineDrawStrategy : IDrawStrategy
{
    public Shape? Draw(AbstractShape shape)
    {
        if (shape is OOP2.Shapes.Line newLine)
        {
            System.Windows.Shapes.Line line = new()
            {
                Fill = newLine.BackgroundColor,
                Stroke = newLine.PenColor,
                X1 = newLine.TopLeft.X,
                X2 = newLine.DownRight.X,
                Y1 = newLine.TopLeft.Y,
                Y2 = newLine.DownRight.Y,
            };

            return line;
        }
        return null;
    }
}