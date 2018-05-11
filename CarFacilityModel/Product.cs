using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarFacilityModel
{
    [Serializable, XmlRoot("product")]
    public class Product
    {
        [XmlElement(ElementName = "productId", Order = 1)]
        public int ProductId { get; set; }
        [XmlElement(ElementName = "type", Order = 2)]
        public string Type { get; set; }
        [XmlElement(ElementName = "name", Order = 3)]
        public string Name { get; set; }
        [XmlElement(ElementName = "partList", Order = 4)]
        public PartList PartList { get; set; }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            s.Append("Product id: " + ProductId);
            s.Append(", Product type: " + Type);
            s.Append(", Product name: " + Name);

            return s.ToString();
        }
    }
}
