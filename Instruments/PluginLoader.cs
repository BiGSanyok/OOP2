using System.Reflection;
using System.Runtime.Loader;
using Microsoft.Win32;
using OOP2.Interfaces;
using OOP2.Shared;

namespace OOP2.Instruments;

public class PluginLoader
{
    public static List<AbstractFactory> LoadPluginShape()
    {
        List<AbstractFactory> list = [];
        OpenFileDialog openFileDialog = new()
        {
            Filter = "Динамическая библиотека (*.dll)|*.dll"
        };
        if (openFileDialog.ShowDialog() == true)
        {
            var context = new AssemblyLoadContext("DynamicLoad", true);
            Assembly assembly = context.LoadFromAssemblyPath(openFileDialog.FileName);
            var types = assembly.GetTypes().Where(type => type.IsSubclassOf(typeof(AbstractFactory)));
            foreach (var type in types)
            {
                if (Activator.CreateInstance(type) is AbstractFactory factory)
                {
                    list.Add(factory);
                }
            }
            context.Unload();
        }

        return list;
    }
    
    public static List<IPlugin> LoadPluginFunctionality()
    {
        List<IPlugin> list = [];
        OpenFileDialog openFileDialog = new()
        {
            Filter = "Динамическая библиотека (*.dll)|*.dll"
        };
        if (openFileDialog.ShowDialog() == true)
        {
            var context = new AssemblyLoadContext("DynamicLoad", true);
            Assembly assembly = context.LoadFromAssemblyPath(openFileDialog.FileName);
            var type = assembly.GetTypes().FirstOrDefault(type => typeof(IPlugin).IsAssignableFrom(type));
            if (type != null && Activator.CreateInstance(type) is IPlugin pluginFunctionality)
            {
                list.Add(pluginFunctionality);
            }

            context.Unload();
        }

        return list;
    }

    public static List<AbstractFactory> LoadPluginInCurrentAssembly()
    {
        List<AbstractFactory> list = [];
        //Assembly assembly = Assembly.GetExecutingAssembly(); Должно тогда лежать в папке OOTPISP
        Assembly assembly = Assembly.GetEntryAssembly()!;
        var types = assembly.GetTypes().Where(type => type.IsSubclassOf(typeof(AbstractFactory)));
        foreach (var type in types)
        {
            if (Activator.CreateInstance(type) is AbstractFactory factory)
            {
                list.Add(factory);
            }
        }

        return list;
    }
    
    public List<AbstractFactory> LoadPlugin()
    {
        List<AbstractFactory> list = [];
        OpenFileDialog openFileDialog = new()
        {
            Filter = "Динамическая библиотека (*.dll)|*.dll"
        };
        if (openFileDialog.ShowDialog() == true)
        {
            var context = new AssemblyLoadContext("DynamicLoad", true);
            Assembly assembly = context.LoadFromAssemblyPath(openFileDialog.FileName);
            var types = assembly.GetTypes().Where(type => type.IsSubclassOf(typeof(AbstractFactory)));
            foreach (var type in types)
            {
                if (Activator.CreateInstance(type) is AbstractFactory factory)
                {
                    list.Add(factory);
                }
            }
            context.Unload();
        }

        return list;
    }
}