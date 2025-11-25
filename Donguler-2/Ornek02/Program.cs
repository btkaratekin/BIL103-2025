using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek02
{
    internal class Program
    {
        /*Örnek: ilk 100 asal sayıyı ekrana yazan algoritma ve programı oluşturunuz.
         * Algoritma
         * Sayac=0,Sayi=2
         * WHILE (Sayac<100) DO
         *     Asal=true
         *     FOR X= 2 TO Sayi-1 STEP 1
         *          IF (Sayi % X == 0) THEN
         *              Asal=false
         *          END IF
         *     END FOR
         *     IF (Asal==true) THEN
         *          WRITE Sayi
         *          Sayac=Sayac+1
         *     END IF
         *     Sayi=Sayi+1
         * END WHILE
         */
        static void Main(string[] args)
        {
            int sayac = 0, sayi = 2;
            Console.Write("İlk 100 Asal Sayı..: ");
            while (sayac < 100)
            {
                bool asal = true;
                for (int i = 2; i <= sayi - 1; i = i + 1)
                {
                    if ((sayi % i) == 0)
                    {
                        asal = false;
                    }
                }
                if (asal == true)
                {
                    Console.Write(sayi+" ");
                    sayac = sayac + 1;
                }
                sayi = sayi + 1;
            }
            Console.ReadKey();
        }
    }
}
