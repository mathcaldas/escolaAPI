using System.Xml.Serialization;
using escolaAPI.src.Model;

namespace escolaAPI.src.Service;

public class XmlService
{
    public void SaveToXml<T>(IEnumerable<T> items, string fileName)
    {
        var serializer = new XmlSerializer(typeof(List<T>));
        using var writer = new StreamWriter(fileName);
        serializer.Serialize(writer, items.ToList());
    }
}
