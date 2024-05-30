using System.IO;
using System.Windows;
using System.Xml.Serialization;
using Microsoft.Win32;
using OOP2.Interfaces;
using OOP2.Shared;

namespace OOP2.Instruments;

public class XmlSerializer
{

    

    public static List<AbstractShapeXml>? Deserialize()
    {
        OpenFileDialog openFileDialog = new()
        {
            Filter = "XML файлы (*.xml)|*.xml"
        };
        if (openFileDialog.ShowDialog() == true)
        {
            return Deserialize(openFileDialog.FileName);
        }
        return null;
    }

    public static List<AbstractShapeXml>? Deserialize(string filePath)
    {
        try
        {
            using FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
            return Deserialize(fs);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при открытии файла XML: {ex.Message}");
        }

        return null;
    }

    public static List<AbstractShapeXml>? Deserialize(Stream stream)
    {
        System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<AbstractShapeXml>));
        if (serializer.Deserialize(stream) is List<AbstractShapeXml> { Count: not 0 } loadedShapes)
        {
            
            return loadedShapes;
        }

        return null;
    }

    public static string Serialize(IEnumerable<AbstractShape> abstractShapes)
    {
        SaveFileDialog saveFileDialog = new()
        {
            Filter = "XML файлы (*.xml)|*.xml|Все файлы (*.*)|*.*"
        };
        if (saveFileDialog.ShowDialog() == true)
        {
            if (!saveFileDialog.FileName.EndsWith(".xml"))
            {
                saveFileDialog.FileName += ".xml";
            }

            using FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create);
            
            List<AbstractShapeXml> list = new();
            foreach (var item in abstractShapes)
            {
                list.Add(new()
                {
                    Angle = item.Angle,
                    BackgroundColor = item.BackgroundColor,
                    DownRight = item.DownRight,
                    PenColor = item.PenColor,
                    StrokeThickness = item.StrokeThickness,
                    Tag = item.Tag,
                    TopLeft = item.TopLeft
                });
            }

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<AbstractShapeXml>));
            serializer.Serialize(fs, list);
        }

        return saveFileDialog.FileName;
    }
}