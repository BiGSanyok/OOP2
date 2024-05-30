using OOP2.Shared;

namespace OOP2.Interfaces;

public interface IPlugin
{
    public string Name { get; }
    public void SaveToFile(List<AbstractShape> abstractShapes);
    public (bool result, List<AbstractShape>? abstractShapes) LoadFile();
}