using System.Windows.Shapes;
using OOP2.Shared;

namespace OOP2.Interfaces
{
    public interface IDrawStrategy
    {
        Shape? Draw(AbstractShape shape);
    }
}
