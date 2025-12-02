using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Program
    {/* Örnek: Klavyeden girilen bir sayının mutlak değerini ekrana yazan algoritma ve programı oluşturunuz
      * 
      * Algoritma
      * READ Sayi
      * WRITE ABSTRACT(Sayi)
      */
        static void Main(string[] args)
        {
            Console.Title = "Mutlak Değer Hesabı";

            Console.Write("Bir sayı girin: ");
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mutlak Değer: " + Math.Abs(sayi));
            Console.ReadKey();
        }
    }
}
