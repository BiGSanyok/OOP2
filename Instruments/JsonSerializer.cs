using OOP2.Shared;
using System.IO;
using System.Text;
using System.Windows;
using Microsoft.Win32;
using Newtonsoft.Json;
using OOP2.Interfaces;


namespace OOP2.Instruments;

public class JsonSerializer : IPlugin
{
    public string Name { get; } = "";
    public void SaveToFile(List<AbstractShape> abstractShapes)
    {
        Serialize(abstractShapes);
    }

    public (bool result, List<AbstractShape>? abstractShapes) LoadFile()
    {
        var result = Deserialize();
        return (result!.Count > 0, result);
    }
    
    public void Serialize(IEnumerable<AbstractShape> abstractShapes)
    {
        SaveFileDialog saveFileDialog = new()
        {
            Filter = "JSON файлы (*.json)|*.json|Все файлы (*.*)|*.*"
        };
        if (saveFileDialog.ShowDialog() == true)
        {
            if (!saveFileDialog.FileName.EndsWith(".json"))
            {
                saveFileDialog.FileName += ".json";
            }

            using FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create);

            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.Objects
            };
            string json = JsonConvert.SerializeObject(abstractShapes, settings);
            byte[] bytes = Encoding.UTF8.GetBytes(json);
            fs.Write(bytes, 0, bytes.Length);
        }
    }

    public List<AbstractShape>? Deserialize()
    {
        OpenFileDialog openFileDialog = new()
        {
            Filter = "JSON файлы (*.json)|*.json"
        };
        if (openFileDialog.ShowDialog() == true)
        {
            try
            {
                string json = File.ReadAllText(openFileDialog.FileName);

                var settings = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.Objects,
                };
                List<AbstractShape>? loadedShapes = JsonConvert.DeserializeObject<List<AbstractShape>>(json, settings);
                return loadedShapes;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла JSON: {ex.Message}");
                return null;
            }
        }
        return null;
    }
}