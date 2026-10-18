using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soPT = 0;
        nhap_lai_soPT:
            Console.Write("Nhap so luong phan tu cua mang: ");
            if (!int.TryParse(Console.ReadLine(), out soPT))
            {
                Console.WriteLine("Gia tri nay khong phai la so. Hay nhap lai.");
                goto nhap_lai_soPT;
            }

            int[] arr = new int[soPT];

            Console.WriteLine("Nhap vao mang: ");
            for (int i = 0; i < soPT; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int tong = 0, min = arr[0], max = arr[0];

            Console.Write("Tong cua mang la: ");
            for (int i = 0; i < soPT; i++)
            {
                tong += arr[i];
            }
            Console.Write(tong.ToString() + "\n");

            for (int i = 1;i < soPT; i++)
            {
                if (min > arr[i]) min = arr[i];
                if (max < arr[i]) max = arr[i];
            }
            Console.WriteLine("So nguyen nho nhat trong mang la " + min.ToString());
            Console.WriteLine("So nguyen lon nhat trong mang la " + max.ToString());
        }
    }
}
