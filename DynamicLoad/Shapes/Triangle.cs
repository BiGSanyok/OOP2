using OOP2.Shared;
using System;
using System.Windows.Media;
using OOP2.Strategy;


namespace OOP2.Shapes;

class Triangle : AbstractShape
{
    public override object Tag => "5";
    public Point VertexOX { get; set; }
    public Point VertexOY { get; set; }

    public Triangle(Point topLeft, Point downRight, Brush bgColor, Brush penColor, int angle)
        : base(topLeft, downRight, bgColor, penColor, angle)
    {
        DrawStrategy = new TriangleDrawStrategy();
        CalculateVertexByX(TopLeft, DownRight);
        CalculateVertexByY(TopLeft, DownRight);
    }

    public void CalculateVertexByX(Point vertex, Point endPoint)
    {
        VertexOX = new(vertex.X + Math.Abs(endPoint.X - vertex.X), vertex.Y);
    }
    public void CalculateVertexByY(Point vertex, Point endPoint)
    {
        float sideOX = Math.Abs(vertex.X - endPoint.X);
        float sideOY = Math.Abs(vertex.Y - endPoint.Y);

        float center = sideOX / 2;
        float height = sideOY;
        VertexOY = new Point(vertex.X + center, vertex.Y - height);
    }

    public override string ToString() =>
        $"{nameof(Triangle)}: Vertex1=({TopLeft.X}-{TopLeft.Y}), Vertex2=({VertexOX.X}-{VertexOX.Y}), Vertex3=({VertexOY.X}-{VertexOY.Y})";
}