using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek08
{
    internal class Program
    {
        /* Örnek: Klavyden girilen ad soyad bilgisi birleştirip ekrana yazan programı oluşturunuz.
         */ 
        static void Main(string[] args)
        {
            Console.Write("Adınızı Girin...:");
            string ad = Console.ReadLine();
            Console.Write("Soyadınızı Girin...:");
            string soyad = Console.ReadLine();
            string adsoyad = string.Concat(ad," ",soyad);
            Console.WriteLine("Adı Soyadı...:{0}",adsoyad);
            Console.ReadKey();
        }
    }
}
