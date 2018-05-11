using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarFacilityModel
{
    [Serializable, XmlRoot("productList")]
    public class ProductList
    {
        [XmlElement("product")]
        public List<Product> Products { get; set; }

        public ProductList()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product p)
        {
            Products.Add(p);
        }

        public Product RemoveProduct(int ProductId)
        {
            Product p = Products.Find(x => x.ProductId == ProductId);
            Products.Remove(p);

            return p;
        }

        public Product GetProduct(int ProductId)
        {
            return Products.Find(x => x.ProductId == ProductId);
        }

        public List<Product> GetList()
        {
            return Products;
        }

        public int Count()
        {
            return Products.Count();
        }

        public override String ToString()
        {
            StringBuilder s = new StringBuilder();

            foreach (var item in Products)
            {
                s.Append(item.ToString());
            }
            return s.ToString();
        }
    }
}
