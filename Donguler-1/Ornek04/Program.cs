using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek04
{
    internal class Program
    {
        /* Örnek: 1+1/2+1/3+...+1/100 işleminin sonucunu ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * Toplam = 0
         * FOR X=1 TO 100 STEP 1
         *      Toplam = Toplam + (1 / X)
         * END FOR
         * WRITE Toplam
         */
        static void Main(string[] args)
        {
            double toplam = 0;
            for (double i = 1; i <= 100; i++)
            {
                toplam = toplam + (1 / i);
            }
            Console.WriteLine("İşlemin Sonucu....: {0}", toplam);
            Console.ReadKey();
        }
    }
}
