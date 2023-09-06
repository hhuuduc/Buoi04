using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai10
{
    class Order
    {
        private int _orderID;

        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }
        private DateTime _orderDate;

        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        private List<OrderDetail> _lineItems;

        internal List<OrderDetail> LineItems
        {
            get { return _lineItems; }
            set { _lineItems = value; }
        }

        //public void AddLineItem(Product p, int x)
        //{
        //    LineItems.Add(new OrderDetail(p, x));
        //}

        public Order(int orderID, DateTime orderDate, List<OrderDetail> list)
        {
            this.OrderID = orderID;
            this.OrderDate = orderDate;
            this.LineItems = list;
        }

        public double CalcTotalCharge()
        {
            double ThanhTien = 0;
            foreach (OrderDetail Item in LineItems)
            {
                ThanhTien += Item.CalcTotalPrice();
            }
            return ThanhTien;
        }

        public void ShowOrder()
        {
            Console.WriteLine("Mã HĐ: {0}", OrderID);
            Console.WriteLine("Ngày lập hóa đơn: {0}", OrderDate);
            Console.WriteLine("{0,-5}|{1, -10}|{2, -20}|{3,10}|{4,10}|{5,20}", "STT", "Mã SP", "Mô tả", "Đơn giá", "Số lượng", "Thành tiền");
            int count = 1;
            foreach (OrderDetail Item in LineItems)
            {
                Console.WriteLine("{0,-5}|{1, -10}|{2, -20}|{3,10}|{4,10}|{5,16} VNĐ", count, Item.Product.ProductID, Item.Product.Description, Item.Product.Price, Item.Quatity, Item.CalcTotalPrice());
                count++;
            }
            Console.WriteLine("Tổng tiền thanh toán: {0} VNĐ", CalcTotalCharge());
        }

        //public Order()
        //{
        //    this.OrderID = 1;
        //    this.OrderDate = new DateTime(2015, 09, 10);
        //}

    }
}
