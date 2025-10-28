using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Program
    {
        /*Örnek: Klavyeden girilen bir sayının mutlak değerini ekrana yazan algoritmayı ve programı oluşturunuz.
         * 
         * Algoritma
         * READ Sayi
         * IF (Sayi<0) THEN
         *   Sayi = Sayi * -1
         * END IF
         * WRITE Sayi
         */
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Girin...:");
            double Sayi = Convert.ToDouble(Console.ReadLine());
            if (Sayi < 0)
            {
                Sayi = Sayi * -1;
            }
            Console.WriteLine("Sayının Mutlak Değeri: " + Sayi);
            Console.ReadKey();
        }
    }
}
