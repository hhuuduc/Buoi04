using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo td = new ToaDo();
            td.Ten = "O";
            td.X = 5;
            td.Y = 5;
            HinhTron ht = new HinhTron(td, 10.5);
            Console.WriteLine("Hình tròn có tâm {0}({1},{2}) với bán kính {3} có diện tích và chu vi lần lượt là {4} và {5}", td.Ten, td.X, td.Y, ht.BanKinh, Math.Round(ht.tinhDienTich(),3), Math.Round(ht.tinhChuVi(),3));
            Console.ReadLine();
        }
    }
}
