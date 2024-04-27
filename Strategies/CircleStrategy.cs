using OOP1;
using OOP2.Shared;
using System.Windows.Shapes;

namespace OOP2.Strategies
{
    public class CircleStrategy : IDrawStrategy
    {
        public Shape Draw(AbstractShape shape)
        {
            if (shape is Circle circle)
                Shape circle = new Ellipse();
            return null;
        }
    }
}
