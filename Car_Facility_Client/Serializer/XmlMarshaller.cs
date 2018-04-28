using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_Marshaller
{
    public class XmlMarshaller
    {
        public T CreateObjectFromXMLString<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var reader = new StringReader(xml))
            {
                return (T) serializer.Deserialize(reader);
            }
        }

        public string CreateXMLString<T>(T t)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var stringWriter = new StringWriter())
            {
                serializer.Serialize(stringWriter, t);
                return stringWriter.ToString();
            }
        }
    }
}
