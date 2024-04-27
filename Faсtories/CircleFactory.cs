﻿using OOP2.Shared;
using System.Windows.Media;
using OOP2.Shapes.EllipseType;

namespace OOP2.Faсtories;

public class CircleFactory : AbstractFactory
{
    public override AbstractShape CreateShape(Point topLeft, Point downRight, Brush bgColor, Brush penColor)
    {
        return new Circle(topLeft, downRight, bgColor, penColor);
    }
}
