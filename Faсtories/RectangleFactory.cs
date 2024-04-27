﻿using OOP2.Shared;
using System.Windows.Media;
using OOP2.Shapes.RectangleType;

namespace OOP2.Faсtories;

public class RectangleFactory : AbstractFactory
{
    public override AbstractShape CreateShape(Point topLeft, Point downRight, Brush bgColor, Brush penColor)
    {
        return new Rectangle(topLeft, downRight, bgColor, penColor);
    }
}
