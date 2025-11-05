using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek02
{
    internal class Program
    {
        /* Örnek: 1 den 100 e kadar olan sayıları ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * FOR X=1 TO 100 STEP 1
         *      WRITE X
         * END FOR
         */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
