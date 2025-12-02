using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek03
{
    internal class Program
    { /*Örnek: Klavyeden girilen 10 adet sayıdan en küçüğünü ve en büyüğünü ekrana yazan algoritma ve programı oluşturunuz.
       * 
       * Ek=0,Eb=0
       * FOR X=1 TO 10 STEP 1
       *        READ Sayi
       *        Ek=MIN(Ek,Sayi)
       *        Eb=MAX(Eb,Sayi)
       * END FOR
       * WRITE Ek,Eb
       */
        static void Main(string[] args)
        {
            Console.Title = "En Küçük ve En Büyük Sayı Bulma";
            double enKucuk = double.MaxValue;
            double enBuyuk = double.MinValue;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0}. Sayıyı Girin: ", i);
                double sayi = Convert.ToDouble(Console.ReadLine());
                enKucuk = Math.Min(enKucuk, sayi);
                enBuyuk = Math.Max(enBuyuk, sayi);
            }
            Console.WriteLine("Girdiğiniz Sayıların En Küçüğü {0}, En Büyüğü {1} dir. ", enKucuk,enBuyuk);
            Console.WriteLine("En Büyük Sayı: " + enBuyuk);
            Console.ReadKey();
        }
    }
}
