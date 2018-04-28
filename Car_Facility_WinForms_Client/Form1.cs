using Car_Facility_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XML_Marshaller;

namespace Car_Facility_WinForms_Client
{
    public partial class CarClient : Form
    {
        private XmlMarshaller marshaller = new XmlMarshaller();
        ICarService.CarServicePortTypeClient client = new ICarService.CarServicePortTypeClient();

        public CarClient()
        {
            InitializeComponent();
        }

        private void GetStolenPartsButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
            var car = new Car()
            {
                ChassisNumber = chassisNoTextField.Text
            };

            string partListXml = client.traceStolenParts(marshaller.CreateXMLString(car));
            var partList = marshaller.CreateObjectFromXMLString<PartList>(partListXml);

            foreach (var part in partList.GetList())
            {
                outputListBox.Items.Add(part.ToString());
                outputListBox.Items.Add("---");
            }
        }

        private void GetCarDetailsButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();

            string carXml = client.traceStolenCar(chassisNoTextField.Text);
            var carDetails = marshaller.CreateObjectFromXMLString<Car>(carXml);

            outputListBox.Items.Add(carDetails.ToString());
        }

        private void GetStolenProductsButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
            var car = new Car()
            {
                ChassisNumber = chassisNoTextField.Text
            };

            string productListXml = client.traceStolenProducts(marshaller.CreateXMLString(car));
            ProductList productList = marshaller.CreateObjectFromXMLString<ProductList>(productListXml);

            foreach (var product in productList.GetList())
            {
                outputListBox.Items.Add(product.ToString());
                outputListBox.Items.Add("---");
            } 
        }
    }
}
