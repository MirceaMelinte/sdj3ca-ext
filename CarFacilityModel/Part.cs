using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarFacilityModel
{
    [Serializable, XmlRoot("part")]
    public class Part
    {
        [XmlElement(ElementName = "partId", Order = 1)]
        public int PartId { get; set; }
        [XmlElement(ElementName = "type", Order = 2)]
        public string Type { get; set; }
        [XmlElement(ElementName = "weight", Order = 3)]
        public double Weight { get; set; }

        public Part() { }

        public override String ToString()
        {
            StringBuilder s = new StringBuilder();

            s.Append("Part id: " + PartId);
            s.Append(", Part type: " + Type);
            s.Append(", Weight: " + Weight);

            return s.ToString();
        }
    }
}
