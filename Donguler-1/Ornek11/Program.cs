using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek11
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen bir sayının asal olup olmadığını ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ Sayi
         * Asal = true
         * FOR X=2 TO Sayi-1 STEP 1
         *      IF (Sayi % X) = 0 THEN
         *          Asal = false
         *      END IF
         * END FOR
         * IF (Asal = true) THEN
         *      WRITE "Sayi Asaldır."
         * ELSE
         *      WRITE "Sayi Asal Değildir."
         * END IF
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool asal = true;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    asal = false;
                }
            }
            if (asal==true)
            {
                Console.WriteLine("Sayi Asaldır.");
            }
            else
            {
                Console.WriteLine("Sayi Asal Değildir.");
            }
            Console.ReadKey();
        }
    }
}
