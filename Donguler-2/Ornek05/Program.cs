using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek05
{
    internal class Program
    {
        /* Örnek: Ekrana 20 adet 3 basamaklı rakamları birbirinden farklı rastgele sayılar yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * Sayac=1
         * DO
         *      Sayi=RANDOM(100,1000)
         *      yuzler = Sayi/100
         *      onlar = Sayi%100/10
         *      birler = Sayi%10
         *      IF (yuzler!=onlar AND yuzler!=birler AND onlar!=birler) THEN
         *          WRITE Sayi
         *          Sayac=Sayac+1
         *      END IF
         *      
         * WHILE (Sayac<=20)
         */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Sayac = 1;
           do
            {
                int Sayi = rnd.Next(100, 1000);
                int yuzler = Sayi / 100;
                int onlar = Sayi % 100 / 10;
                int birler = Sayi % 10;
                if (yuzler != onlar && yuzler != birler && onlar != birler)
                {
                    Console.Write(Sayi + " ");
                    Sayac++;
                }

            } while (Sayac <= 20);
            Console.ReadKey();
        }
    }
}
