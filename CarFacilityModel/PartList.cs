using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarFacilityModel
{
    [Serializable, XmlRoot("partList")]
    public class PartList
    {
        [XmlElement("part")]
        public List<Part> Parts { get; set; }

        public PartList()
        {
            Parts = new List<Part>();
        }

        public void AddPart(Part p)
        {
            Parts.Add(p);
        }

        public Part RemovePart(int partId)
        {
            Part p = Parts.Find(x => x.PartId == partId);
            Parts.Remove(p);

            return p;
        }

        public Part GetPart(int partId)
        {
            return Parts.Find(x => x.PartId == partId);
        }

        public List<Part> GetList()
        {
            return Parts;
        }

        public int Count()
        {
            return Parts.Count();
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            foreach (var part in Parts)
            {
                s.Append(part.ToString());
            }
            
            return s.ToString();
        }
    }
}
