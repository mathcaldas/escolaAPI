using System.Xml.Serialization;
using escolaAPI.src.Model;

namespace escolaAPI.src.Service;

public class XmlService
{
    public string TransformToXml<T>(T data)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
        using StringWriter textWriter = new StringWriter();
        xmlSerializer.Serialize(textWriter, data);
        return textWriter.ToString();
    }
}
