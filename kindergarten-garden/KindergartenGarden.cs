using System;
using System.Collections.Generic;
using System.Linq;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class Garden
{
    private readonly List<string> _children = null;
    private readonly string[] _windowSills;
    private static readonly Dictionary<char, Plant> _plants = 
        Enum.GetNames(typeof(Plant)).ToDictionary(e => e[0], l => (Plant)Enum.Parse(typeof(Plant), l));

    public Garden(IEnumerable<string> children, string windowSills)
    {
        _children = children.ToList();
        _windowSills = windowSills.Split('\n');
        _children.Sort();
    }

    public IEnumerable<Plant> GetPlants(string child)
    {
        var idxChild = _children.IndexOf(child);
        if (idxChild < 0)
            return Enumerable.Empty<Plant>();

        idxChild = idxChild * 2;

        var chars = _windowSills[0].Substring(idxChild, 2)
                    + _windowSills[1].Substring(idxChild, 2);

        return chars.Select(chr => _plants[chr]);
    }

    public static Garden DefaultGarden(string windowSills)
    {
        var garden = new Garden(new[] { "Alice", "Bob", "Charlie", "David",
        "Eve","Fred","Ginny","Harriet", "Ileana","Joseph","Kincaid","Larry"}, windowSills);
        return garden;
    }
}