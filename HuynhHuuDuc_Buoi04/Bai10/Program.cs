using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OrderDetail> lineItems = new List<OrderDetail>();
            lineItems.Add(new OrderDetail(new Product("Nước tương", "sp4", 8000), 10));
            lineItems.Add(new OrderDetail(new Product("Gạo", "sp1", 18000), 5));
            lineItems.Add(new OrderDetail(new Product("Đường", "sp3", 10000), 1));
            lineItems.Add(new OrderDetail(new Product("Gạo", "sp1", 18000), 1));

            Order or = new Order(1, new DateTime(2015, 09, 10), lineItems);
            or.ShowOrder();
            Console.ReadLine();
        }
    }
}
