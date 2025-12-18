using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek07
{
    internal class Program
    {
        /*Örnek: Rastgele üretilen 100 adet 3 basamaklı sayılar dizisinde klavyeden girilen bir sayının kaçıncı sırada olduğunu ekrana yazan programı oluşturunuz.
         */
        static void Main(string[] args)
        {
            int[] sayilar = new int[100];
            Random rnd = new Random();
            Console.WriteLine("Rastgele 100 Adet Sayı");
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(100, 1000);
                Console.Write(sayilar[i] + " ");
            }
            Console.Write("\n\nAradığınız Sayıyı Girin....: ");
            int aranan = int.Parse(Console.ReadLine());
            int index = Array.IndexOf(sayilar, aranan);
            if (index == -1)
            {
                Console.WriteLine("Aradığınız {0} Sayısı Sayılar Dizisinde Bulunamadı.", aranan);
            }
            else
            {
                Console.WriteLine("{0} sayısı dizinin {1}. elemanıdır.", aranan, index + 1);
            }
            Console.ReadKey();
        }
    }
}
