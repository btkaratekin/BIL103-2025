using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    /* Örnek: 1 den 100 e kadar olan sayıları ekrana yazan algoritma ve programı oluşturunuz.
     * 
     * Algoritma
     * Sayac=1
     * WHILE (Sayac<=100) DO
     *      WRITE Sayac
     *      Sayac=Sayac + 1
     * END WHILE
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            while (sayac <= 100)
            {
                Console.WriteLine(sayac);
                sayac = sayac + 1;
            }
            Console.ReadKey();
        }
    }
}
