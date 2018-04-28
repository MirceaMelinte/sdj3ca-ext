using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Facility_Model;
using XML_Marshaller;

namespace Serializer_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car
            {
                ChassisNumber = "GGG"
            };

            var ser = new XmlMarshaller();

            string s = ser.CreateXMLString(c);

            var client = new ICarService.CarServicePortTypeClient();



            Console.WriteLine(client.traceStolenParts(s));

            Console.ReadKey();
        }
    }
}
