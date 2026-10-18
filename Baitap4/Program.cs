using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hoTen = "";
            Console.Write("Nhap ho ten cua ban: ");
            hoTen = Console.ReadLine();

            string ho = "", tenDem = "", ten = "";
            hoTen = hoTen.Trim();

            string[] tungPhan = hoTen.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            ten = tungPhan[tungPhan.Length - 1].Substring(0, 1).ToUpper() +
                tungPhan[tungPhan.Length - 1].Substring(1, tungPhan[tungPhan.Length - 1].Length - 1).ToLower();

            if (tungPhan.Length > 1)
            {
                ho = tungPhan[0].Substring(0, 1).ToUpper() + tungPhan[0].Substring(1, tungPhan[0].Length - 1).ToLower();
            }
            
            if (tungPhan.Length > 2)
            {
                for (int i = 1; i < tungPhan.Length - 1; i++)
                {
                    tungPhan[i] = tungPhan[i].Substring(0, 1).ToUpper() + tungPhan[i].Substring(1, tungPhan[i].Length - 1).ToLower();
                }
                tenDem = string.Join(" ", tungPhan, 1, tungPhan.Length - 2);
            }

            if (tungPhan.Length > 1)
            {
                Console.WriteLine("Ho cua ban la: " + ho);
            }
            if (tungPhan.Length > 2)
            {
                Console.WriteLine("Ten dem cua ban la: " + tenDem);
            }
            Console.WriteLine("Ten cua ban la: " + ten);

            Console.WriteLine("Ho ten day du cua ban la {0} {1} {2}", ho, tenDem, ten);
        }
    }
}
