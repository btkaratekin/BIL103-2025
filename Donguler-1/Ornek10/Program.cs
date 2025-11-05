using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek10
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen kolon sayısı kadar her bir kolon için 1 ile 19 arasında rastgele 6 adet sayı üreten algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ KolonSayisi
         * FOR X=1 TO KolonSayisi STEP 1
         *     FOR Y=1 TO 6 STEP 1
         *          WRITE RANDOM(1,50)
         *     END FOR
         * END FOR
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Kolon Sayısını Girin...:");
            int kolonSayisi = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 1; i <= kolonSayisi; i++)
            {
                Console.WriteLine("{0}. Kolon:", i);
                for (int j = 1; j <= 6; j++)
                {
                    int rastgeleSayi = rnd.Next(1, 50);
                    Console.Write(rastgeleSayi + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
