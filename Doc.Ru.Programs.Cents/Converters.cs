using System.Collections;

namespace Doc.Ru.Programs.Cents;

public static class Converters
{
    public static Dictionary<string, uint> ValletToDictionary(Vallet vallet)
    {
        var result = vallet.GetType().GetProperties()
                            .ToDictionary(key => key.Name, v => (uint)v.GetValue(vallet, null));

        return result;
    }

    public static  Hashtable ValletToHashTable(Vallet vallet)
    {
        Hashtable result = new Hashtable();
        var properties = vallet.GetType().GetProperties().ToList();
        properties.ForEach(p=>result.Add(p.Name, p.GetValue(vallet, null)));
        return result;
    }
}
