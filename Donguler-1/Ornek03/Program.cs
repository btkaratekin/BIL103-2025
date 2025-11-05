using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek03
{
    internal class Program
    {
        /* Örnek: 100 den 1 e kadar olan çift sayıları ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * FOR X=100 DOWN TO 1 STEP 2
         *      WRITE X
         * END FOR
         */
        static void Main(string[] args)
        {
            for (int i = 100; i > 1; i =i-2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
