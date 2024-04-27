using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Shapes;
using OOP2.Shared;
using OOP2;
using System.ComponentModel;
using System.Windows.Markup;

namespace OOP2;

public partial class ShapeEditor : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    AbstractShape _shape;
    public AbstractShape Shape
    {
        get => _shape;
        set
        {
            _shape = value;
            OnPropertyChanged(nameof(Shape));
        }
    }

    public ShapeEditor(AbstractShape shape)
    {
        InitializeComponent();
        Shape = shape;
    }

    void ApplyButton_Click(object sender, RoutedEventArgs e)
    {
        Shape.Angle %= 360;

        if (Shape.Angle < 0)
            Shape.Angle += 360;

        /*if (Shape is MyTriangle myTriangle)
        {
            myTriangle.RecalculateOX();
            myTriangle.RecalculateOY();
        }*/
    }

    protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}