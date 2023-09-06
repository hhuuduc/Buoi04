using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Product
    {
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private string _productID;

        public string ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Product() { }

        public Product(string description, string productID, double price)
        {
            this.Description = description;
            this.ProductID = productID;
            this.Price = price;
        }
    }
}
