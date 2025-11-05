using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek09
{
    internal class Program
    {
        /* Örnek: Bir gün içerisindeki tüm saat ve dakika değerlerini ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * FOR X=0 TO 23 STEP 1
         *      FOR Y=0 TO 59 STEP 1
         *      WRITE X+":"+Y
         *      END FOR
         * END FOR
         */
        static void Main(string[] args)
        {
            Console.Title = "Gün İçerisindeki Tüm Saat ve Dakika Değerleri";
            for (int saat = 0; saat < 24; saat++)
            {
                for (int dakika = 0; dakika < 60; dakika++)
                {
                    Console.WriteLine("{0}:{1}", saat.ToString("D2"), dakika.ToString("D2"));
                }
            }
            Console.ReadKey();
        }
    }
}
