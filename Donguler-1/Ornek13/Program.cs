using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek13
{
    internal class Program
    {
        /*Örnek: Klavyeden girilen 10 adet sayıdan tek olanlarının toplamı ile çift olanların toplamı arasındaki farkı ekrana yazan algoritma ve programı oluşturunuz. 
         * 
         * TekToplam=0,CiftToplam=0
         * FOR I=1 TO 10 STEP 1
         *      READ Sayi
         *      IF (Sayi%2)==0) THEN
         *          CiftToplam=CiftToplam+Sayi
         *      ELSE
         *          TekToplam=TekToplam+Sayi
         *      END IF
         * END FOR
         * WRITE TekToplam-CiftToplam
         */
        static void Main(string[] args)
        {
            int TekToplam = 0, CiftToplam = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Sayi: ");
                int Sayi = Convert.ToInt32(Console.ReadLine());

                if (Sayi % 2 == 0)
                {
                    CiftToplam += Sayi;
                }
                else
                {
                    TekToplam += Sayi;
                }
            }

            Console.WriteLine("Tek Sayıların Toplamı ile Çift Sayıların Toplamı Arasındaki Fark {0} dir.",(TekToplam - CiftToplam));
            Console.ReadKey();
        }
    }
}
