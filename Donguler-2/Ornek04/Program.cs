using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek04
{
    internal class Program
    {
        /* 1 den 100 e kadar olan sayıları ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * Sayac=1
         * DO
         *     WRITE Sayac
         *     Sayac= Sayac+1
         * WHILE(Sayac<=100)
         */
        static void Main(string[] args)
        {
            int Sayac = 1;
            do
            {
                Console.WriteLine(Sayac);
                Sayac = Sayac + 1;
            } while (Sayac <= 100);
            Console.ReadKey();
        }
    }
}
