using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Program
    {
        /*Örnek: Ekrana 100 defa "PROGRAMLAMA TEMELERİ" Mesajını yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * FOR X=1 TO 100 STEP 1
         *      WRITE "PROGRAMLAMA TEMELERİ"
         * END FOR
         */
        static void Main(string[] args)
        {
            for (int i = 1; i <=100; i=i+1)
            {
                Console.WriteLine("PROGRAMLAMA TEMELLERİ");
            }
            Console.ReadKey();
        }
    }
}
