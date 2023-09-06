using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class OrderDetail
    {
        private int _quatity;

        public int Quatity
        {
            get { return _quatity; }
            set { _quatity = value; }
        }
        private Product _product;

        internal Product Product
        {
            get { return _product; }
            set { _product = value; }
        }


        public OrderDetail(Product product, int quatity)
        {
            this.Product = product;
            this.Quatity = quatity;
        }

        public double CalcTotalPrice()
        {
            return Quatity * Product.Price;
        }

        public OrderDetail() { }

    }
}
