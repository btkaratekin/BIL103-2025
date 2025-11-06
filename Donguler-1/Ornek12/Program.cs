using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12
{
    internal class Program
    {
        /*Örnek: Klavyeden girilen 2 adet sayının Ortak Bölenlerinin En Büyüğünü (OBEB) ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ Sayi1
         * READ Sayi2
         * IF (Sayi1 < Sayi2) THEN
         *      Min = Sayi1
         * ELSE
         *      Min = Sayi2
         * END IF
         * FOR X=1 TO Min STEP 1
         *      IF ( (Sayi1 % X) = 0 AND (Sayi2 % X) = 0 ) THEN
         *          OBEB = X
         *      END IF
         * END FOR
         * WRITE OBEB
         */
        static void Main(string[] args)
        {

            Console.Title = "OBEB Hesaplama";
            Console.Write("1. Sayıyı Girin....:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Girin....:");
            int sayi2 = int.Parse(Console.ReadLine());
            int min = sayi1 < sayi2 ? sayi1 : sayi2;
            int obeb = 1;
            for (int i = 1; i <= min; i++)
            {
                if (((sayi1 % i) == 0) && ((sayi2 % i) == 0))
                {
                    obeb = i;
                }
            }
            Console.WriteLine("{0} ile {1} Sayılarının En Büyük Ortak Böleni {2} dir.", sayi1, sayi2, obeb);
            Console.ReadKey();
        }
    }
}
