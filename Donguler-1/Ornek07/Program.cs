using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek07
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen bir sayının faktöriyelini ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ Sayi
         * Faktoriyel = 1
         * FOR X=1 TO Sayi STEP 1
         *      Faktoriyel = Faktoriyel * X
         * END FOR
         * WRITE Faktoriyel
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Faktöriyelini Hesaplamak İstediğiniz Sayıyı Girin..:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            Console.WriteLine("{0} Sayısının Faktöriyeli: {1}", sayi, faktoriyel);
            Console.ReadKey();

        }
    }
}
