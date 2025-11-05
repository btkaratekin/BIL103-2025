using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek05
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen 10 adet sayıdan kaç tanesinin tek, kaç tanesinin çift olduğunu ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritm
         * Tekler = 0,Ciftler = 0
         * FOR X=1 TO 10 STEP 1
         *      READ Sayi
         *      IF ((Sayi % 2) = 0) THEN
         *          Ciftler = Ciftler + 1
         *      ELSE
         *          Tekler = Tekler + 1
         *      END IF
         * END FOR
         * WRITE Ciftler, Tekler    
         */
        static void Main(string[] args)
        {
            int tekler = 0, ciftler = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + ". Sayıyı Girin....:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if ((sayi % 2) == 0)
                {
                    ciftler++;
                }
                else
                {
                    tekler++;
                }
            }
            Console.WriteLine("Girilen Sayılardan {0} Adedi Çift, {1} Adedi Tektir", ciftler, tekler);
            Console.ReadKey();
        }
    }
}
