using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek03
{
    internal class Program
    {
        /* Klavyeden girilen bir sayının tek yada çift olduğunu ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ Sayi
         * IF(Sayi%2==0) THEN
         *  WRITE "Çift Sayı"
         * ELSE
         *  WRITE "Tek Sayı"
         * END IF
         * */
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Girin...:");
            int Sayi = Convert.ToInt32(Console.ReadLine());
            if (Sayi % 2 == 0)
            {
                Console.WriteLine("Çift Sayı");
            }
            else
            {
                Console.WriteLine("Tek Sayı");
            }
            Console.ReadKey();
        }
    }
}
