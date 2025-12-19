using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Program
    {
        /* Örnek: Klavyeden 5 adet öğrenci için sırasıyla vize ve final notu alınıp, arkasından bu notlardan başarı notlarını hesaplayarak ekranda liste biçimde gösteren programı oluşturunuz.
         */
        static void Main(string[] args)
        {
            int[,] notlar = new int[5, 3];
            for (int i = 0; i < notlar.GetLength(0); i++)
            {
                Console.Write("{0}. Öğrencinin Vize Notu: ", i + 1);
                notlar[i, 0] = int.Parse(Console.ReadLine());
                Console.Write("{0}. Öğrencinin Final Notu: ", i + 1);
                notlar[i, 1] = int.Parse(Console.ReadLine());
                notlar[i, 2] = (int)(notlar[i, 0] * 40/100 + notlar[i, 1] * 60/100);
            }
            int toplam = 0;
            for (int i = 0; i < notlar.GetLength(0); i++)
            {
                toplam = toplam + notlar[i, 2];
            }
            int aort = toplam / notlar.GetLength(0);
            Console.Clear();
            Console.WriteLine("Öğrenci No\tVize\tFinal\tBaşarı Notu");
            for (int i = 0; i < notlar.GetLength(0); i++)
            {
                Console.WriteLine("{0}\t\t{1}\t{2}\t{3}", i + 1, notlar[i, 0], notlar[i, 1], notlar[i, 2]);
            }
            Console.WriteLine("\n Ortalama Başarı Notu: {0}", aort);
            Console.ReadKey();
        }
    }
}
