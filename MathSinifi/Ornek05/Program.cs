using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek05
{
    internal class Program
    {
        /*Örnek: Klavyeden girilen bir sayının yine klavyeden girilen bir kuvvetini ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ Sayi
         * READ Kuvvet
         * WRITE POW(Sayi,Kuvvet)
         */
        static void Main(string[] args)
        {
            Console.Title="Üs Alma İşlemi";
            Console.Write("Bir sayı girin: ");
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kuvvetini girin: ");
            double kuvvet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} sayısının {1}. kuvveti: {2}", sayi, kuvvet, Math.Pow(sayi, kuvvet));
            Console.ReadKey();
        }
    }
}
