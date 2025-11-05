using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek08
{
    internal class Program
    {
        /* Örnek: Çarpım Tablosunu ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * FOR X=1 TO 10 STEP 1
         *      FOR Y=1 TO 10 STEP 1
         *      WRITE (X * Y)
         *      END FOR
         * END FOR
         */
        static void Main(string[] args)
        {
            Console.Title = "Çarpım Tablosu";
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}",i,j, (i * j));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
