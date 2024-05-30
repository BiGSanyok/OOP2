using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Shapes;
using System.Xml.Serialization;
using Microsoft.Win32;
using Newtonsoft.Json;
using OOP2.Faсtories;
using OOP2.Shared;
using OOP2.Command;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using OOP2.Instruments;
using Formatting = System.Xml.Formatting;
using OOP2.Interfaces;
using System.Xml;


namespace OOP2;

public partial class MainWindow 
{
    public MainViewModel MainViewModel { get; } = new();
    public MainWindow()
    {

        InitializeComponent();
        AbstractShape.Canvas = DrawField;
        this.DataContext = MainViewModel;
        MainViewModel.LoadCurrentFiguresDynamic(this);
    }

}