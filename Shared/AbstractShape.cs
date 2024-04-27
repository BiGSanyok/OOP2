using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OOP2.Shared
{
    public abstract class AbstractShape
    {
        private int CanvasIndex = -1;
       
        public IDrawStrategy DrawStrategy { get; protected set; }

        public void DrawAlgorithm()
        {
            var drawnShape = DrawStrategy.Draw(this);

            if (drawnShape != null)
            {
                if (CanvasIndex < 0)
                {
                    CanvasIndex = Canvas.Children.Count;
                    Canvas.Children.Add(drawnShape);
                }
                else
                {
                    Canvas.Children.RemoveAt(CanvasIndex);
                    Canvas.Children.Insert(CanvasIndex, drawnShape);
                }
                drawnShape.Tag = CanvasIndex;
            }
        }


    }
}
