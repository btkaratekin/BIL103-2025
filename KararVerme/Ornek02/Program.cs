using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek02
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen 2 adet sayıdan büyük olanını ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ Sayi1
         * READ Sayi2
         * IF (Sayi1>Sayi2) THEN
         *   WRITE Sayi1
         * ELSE
         *   WRITE Sayi2
         * END IF
         */
        static void Main(string[] args)
        {
            Console.Write("Birinci Sayıyı Girin...:");
            double Sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci Sayıyı Girin...:");
            double Sayi2 = Convert.ToDouble(Console.ReadLine());
            if (Sayi1 > Sayi2)
            {
                Console.WriteLine("Büyük Olan Sayı: " + Sayi1);
            }
            else
            {
                Console.WriteLine("Büyük Olan Sayı: " + Sayi2);
            }
            Console.ReadKey();

        }
    }
}
