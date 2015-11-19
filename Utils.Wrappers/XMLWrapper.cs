using System.Xml;
using System.Xml.Serialization;

namespace Utils.Wrappers
{
    public class XMLWrapper
    {
        public virtual T DeserializeXML<T>(string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var reader = XmlReader.Create(filePath))
                return (T)serializer.Deserialize(reader);
        }

        public virtual void SerializeXML<T>(string filePath, T xmlContent, bool indented = true)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var writer = XmlWriter.Create(filePath, new XmlWriterSettings { Indent = indented }))
                serializer.Serialize(writer, xmlContent);
        }
    }
}
