using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DoToApp2.Helpers
{
    public class XmlHelper
    {
        public static void SerializeToXml<T>(T obj, string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public static T DeserializeToXml<T>(string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var reader = new StreamReader(filePath))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
