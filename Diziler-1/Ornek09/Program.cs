using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ornek09
{
    internal class Program
    {
        /*Örnek: Rakamları ve kendileri birbirinden farklı 3 basamaklı rastgele 100 adet sayıyı büyükten küçüğe doğru sıralayıp ekrana yazdıran programı oluşturunuz.
         */
        static void Main(string[] args)
        {
            int[] sayilar = new int[100];
            Random rnd = new Random();
            int sayac = 0;
            while (sayac<sayilar.Length)
            {
                int sayi = rnd.Next(100, 1000);
                int birler = sayi % 10;
                int onlar = (sayi / 10) % 10;
                int yuzler = sayi / 100;
                if (birler != onlar && birler != yuzler && onlar != yuzler)
                {
                    int indexno = Array.IndexOf(sayilar, sayi);
                    if (indexno==-1)
                    {
                        sayilar[sayac] = sayi;
                        sayac++;
                    }
                }
            }
            Array.Sort(sayilar);
            Array.Reverse(sayilar);
            Console.WriteLine("Rakamları birbirinden farklı 3 basamaklı rastgele 100 adet sayı (Büyükten Küçüğe):");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Thread.Sleep(100);
                Console.Write(sayilar[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
