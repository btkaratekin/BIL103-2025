using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ornek08
{
    internal class Program
    {
        /* Örnek: Kullanıcının hafızada tuttuğu bir 1 ile 1000000 arasındaki rastgele bir sayıyı sistemin sayı tahmini yaparak bulmasını sağlayan ve her tahminden sonra kullanıcıya ipuçu veren algoritma ve programı oluşturunuz.
         * 
         * TutulanSayi = 776725
         * TahminSay=0
         * durum=false
         * alt=1,ust=1000000
         * WHILE(durum==false) DO
         *      Sayi=RANDOM(alt,ust) 
         *      TahminSay=TahminSay+1
         *      IF (Sayi==TutulanSayi) THEN
         *          WRITE TahminSay 
         *          BREAK
         *      ELSE IF (Sayi<TutulanSayi) THEN
         *          alt=Sayi
         *      ELSE
         *          ust=Sayi
         *      END IF
         * END WHILE
         */
        static void Main(string[] args)
        {
            int tutulansayi = 776725;
            Random rnd = new Random();
            int tahminSay = 0;  
            int alt=1,ust=1000000;
            bool durum = false;
            while (durum==false)
            {
                int sayi = rnd.Next(alt, ust);
                tahminSay++;
                Console.WriteLine(sayi);
                if (sayi==tutulansayi)
                {
                    Console.WriteLine("Sayı Bulundu.\nSistem Sayıyı {0} tahminde buldu. ",tahminSay);
                    break;
                }
                else if (sayi<tutulansayi)
                {
                    alt = sayi+1;
                }
                else
                {
                    ust = sayi;
                }
                Thread.Sleep(500);
            }
            Console.ReadKey();
        }
    }
}
