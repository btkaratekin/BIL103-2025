using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek02
{
    internal class Program
    {
        /*Örnek: 10 adet öğrenci için klavyeden girilen notları bir dizi içerisinde saklayınız ve ardından bu notların ortalamasını hesaplayarak ekrana yazdırınız.*/
        static void Main(string[] args)
        {
            int[] notlar = new int[10];
            int toplam = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Öğrenci {0} notunu giriniz: ", i + 1);
                notlar[i] = Convert.ToInt32(Console.ReadLine());
                toplam += notlar[i];
            }

            double ortalama = toplam / 10;
            Console.WriteLine("Notların ortalaması: " + ortalama);
        }
    }
}
