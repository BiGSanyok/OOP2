using System.Windows.Shapes;

namespace OOP2.Shared
{
    public interface IDrawStrategy
    {
        Shape? Draw(AbstractShape shape);
    }
}
