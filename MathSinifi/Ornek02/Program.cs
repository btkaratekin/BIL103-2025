using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek02
{
    internal class Program
    {
        /*Klavyeden girilen ondalıklı bir sayıyı sırasıyla aşağıya,yukarıya ve en yakın tam sayıya yuvarlayan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ OndalikliSayi
         * WRITE CEILING(OndalikliSayi)
         * WRITE FLOOR(OndalikliSayi)
         * WRITE ROUND(OndalikliSayi)
         */
        static void Main(string[] args)
        {
            Console.Title = "Yuvarlama İşlemleri";

            Console.Write("Bir ondalıklı sayı girin: ");
            double ondalikliSayi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Aşağıya Yuvarlama............: " + Math.Floor(ondalikliSayi));
            Console.WriteLine("Yukarıya Yuvarlama...........: " + Math.Ceiling(ondalikliSayi));
            Console.WriteLine("En Yakın Tam Sayıya Yuvarlama: " + Math.Round(ondalikliSayi));

            Console.ReadKey();
        }
    }
}
