using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;
        nhap_lai_a:
            Console.Write("Nhap tham so a: ");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Gia tri cua a khong hop le. Hay nhap lai.");
                goto nhap_lai_a;
            }

        nhap_lai_b:
            Console.Write("Nhap tham so b: ");
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Gia tri cua b khong hop le. Hay nhap lai.");
                goto nhap_lai_b;
            }

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                x = -b / a;
                Console.WriteLine("Phuong trinh co nghiem la: " + x);
            }
        }
    }
}
