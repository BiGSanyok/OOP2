using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace OOP2.Shared
{
    public class AbstractShapeXml()
    {
        public object Tag { get; set; }
        public int CanvasIndex { get; set; }
        public int Angle { get; set; }
        public double StrokeThickness { get; set; } = 1;
        public Point TopLeft { get; set; } = new(0, 0);
        public Point DownRight { get; set; } = new(0, 0);
        [XmlIgnore]
        public Brush BackgroundColor { get; set; }
        [XmlIgnore]
        public Brush PenColor { get; set; } 
        public string BackgroundColorString
        {
            get;// => BackgroundColor.ToString();
            set;// => BackgroundColor = (SolidColorBrush)new BrushConverter().ConvertFromString(value);
        }

        public string PenColorString
        {
            get;// => PenColor.ToString();
            set;//=> PenColor = (SolidColorBrush)new BrushConverter().ConvertFromString(value);
        }


        public AbstractShapeXml(Point topLeft, Point downRight, Brush bgColor, Brush penColor, int angle, string bgColorStr, string penColorStr) : this()
        {
            CanvasIndex = -1;
            TopLeft = topLeft;
            DownRight = downRight;
            Angle = angle;
            BackgroundColor = bgColor;
            PenColor = penColor;
            BackgroundColorString = bgColorStr;
            PenColorString = penColorStr;
        }
    }
}
