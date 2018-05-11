using System;
using System.Windows.Forms;
using Xml_Marshaller;
using CarFacilityModel;

namespace CarFacilityClient
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

            string partListXml = client.traceStolenParts(chassisNoTextField.Text);

            if(partListXml != null)
            { 
                var partList = marshaller.CreateObjectFromXMLString<PartList>(partListXml);

                foreach (var part in partList.GetList())
                {
                    outputListBox.Items.Add(part.ToString());
                    outputListBox.Items.Add("---");
                }
            }

            else
            { 
                outputListBox.Items.Add("Invalid chassis number");
            }
        }

        private void GetCarDetailsButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();

            string carXml = client.traceStolenCar(chassisNoTextField.Text);

            if (carXml != null)
            {
                var carDetails = marshaller.CreateObjectFromXMLString<Car>(carXml);

                outputListBox.Items.Add(carDetails.ToString());
            }
            
            else
            {
                outputListBox.Items.Add("Invalid chassis number");
            }
        }

        private void GetStolenProductsButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();

            string productListXml = client.traceStolenProducts(chassisNoTextField.Text);

            if (productListXml != null)
            {
                ProductList productList = marshaller.CreateObjectFromXMLString<ProductList>(productListXml);

                foreach (var product in productList.GetList())
                {
                    outputListBox.Items.Add(product.ToString());
                    outputListBox.Items.Add("---");
                }
            }
            
            else
            {
                outputListBox.Items.Add("Invalid chassis number");
            }
        }
    }
}
