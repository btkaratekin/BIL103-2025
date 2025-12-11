using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek04
{
    internal class Program
    {
        /*Örnek:0 ile 1 arasında virgülden sonra 3 basamağı olan rastgele 100 adet sayıdan oluşan bir dizi tanımlayınız.
         Ve bu dizinin elemanlarından 0 a yakın olanlarını mavi,1 e yakın olanlarını kırmızı renkte ekrana yazdırınız.  
         */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double[] sayilar = new double[100];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = Math.Round(rnd.NextDouble(), 3);
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]   < 0.5)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(sayilar[i]);
            }
            Console.ResetColor();
        }
    }
}
