using System;
using System.Text;
using System.Xml.Serialization;

namespace CarFacilityModel
{
    [Serializable, XmlRoot("car")]
    public class Car
    {
        [XmlElement(ElementName = "chassisNumber", Order = 1)]
        public string ChassisNumber { get; set; }
        [XmlElement(ElementName = "manufacturer", Order = 2)]
        public string Manufacturer { get; set; }
        [XmlElement(ElementName = "model", Order = 3)]
        public string Model { get; set; }
        [XmlElement(ElementName = "year", Order = 4)]
        public int Year { get; set; }
        [XmlElement(ElementName = "weight", Order = 5)]
        public double Weight { get; set; }
        [XmlElement(ElementName = "state", Order = 6)]
        public string State { get; set; }
        [XmlElement(ElementName = "partList", Order = 7)]
        public PartList parts { get; set; }

        public Car() { }

        public override String ToString()
        {
            StringBuilder s = new StringBuilder();

            s.Append("Chassis number: " + ChassisNumber);
            s.Append(", Manufacturer: " + Manufacturer);
            s.Append(", Model: " + Model);
            s.Append(", Year: " + Year);
            s.Append(", Weight: " + Weight);
            s.Append(", State: " + State);

            return s.ToString();
        }
    }
}
