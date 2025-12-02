using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek04
{
    internal class Program
    {
        /*Örnek: Klavyeden girilen bir sayının karekökünü ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ Sayi
         * WRITE SQRT(Sayi)
         */ 
        static void Main(string[] args)
        {
            Console.Title = "Karekök Hesabı";
            Console.Write("Bir sayı girin: ");
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Karekök: " + Math.Sqrt(sayi));
            Console.ReadKey();
        }
    }
}
