using System;
using System.Text;
using System.Xml.Serialization;

namespace CarFacilityModel
{
    [Serializable, XmlRoot("pallet")]
    public class Pallet
    {
        [XmlElement(ElementName = "palletId", Order = 1)]
        public int PalletId { get; set; }
        [XmlElement(ElementName = "partType", Order = 2)]
        public string PartType { get; set; }
        [XmlElement(ElementName = "weight", Order = 3)]
        public double Weight { get; set; }
        [XmlElement(ElementName = "maxWeight", Order = 4)]
        public double MaxWeight { get; set; }
        [XmlElement(ElementName = "state", Order = 5)]
        public string State{ get; set; }
        [XmlElement(ElementName = "partList", Order = 6)]
        public PartList PartList { get; set; }

        public Pallet() { }

        public override String ToString()
        {
            StringBuilder s = new StringBuilder();

            s.Append("Pallet id: " + PalletId);
            s.Append(", Pallet part type: " + PartType);
            s.Append(", Pallet weight: " + Weight);
            s.Append(", Pallet max weight: " + MaxWeight);
            s.Append(", Pallet state: " + State);

            return s.ToString();
        }
    }
}
