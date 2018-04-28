﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Car_Facility_Model
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
        [XmlElement(ElementName = "car", Order = 4)]
        public Car Car { get; set; }
        [XmlElement(ElementName = "palletId", Order = 5)]
        public int PalletId { get; set; }
        [XmlElement(ElementName = "productId", Order = 6)]
        public int ProductId { get; set; }

        public Part() { }

        public override String ToString()
        {
            StringBuilder s = new StringBuilder();

            s.Append("Part id: " + PartId);
            s.Append(", Pallet id: " + PalletId);
            s.Append(", Prodocut id: " + ProductId);
            s.Append(", Part type: " + Type);
            s.Append(", Weight: " + Weight);

            return s.ToString();
        }
    }
}
