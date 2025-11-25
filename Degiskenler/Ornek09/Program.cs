using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek09
{
    internal class Program
    {
        /* Klavyeden girilen 3 basamaklı bir sayının tersi ile kendisi arasındaki farkı ekrana yazan programı oluşturunuz. 
         * 
         * Algoritma
         * READ Sayi
         * yuzler = Sayi / 100
         * onlar = Sayi / 10 % 10
         * birler= Sayi % 10
         * tersayi = birler * 100 + onlar * 10 + yuzler 
         * fark = Sayi - tersayi
         * WRITE fark
         */
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Girin.....:");
            int sayi = int.Parse(Console.ReadLine());
            int yuzler = sayi / 100;
            int onlar = (sayi / 10) % 10;
            int birler = sayi % 10;
            int tersSayi = (birler * 100) + (onlar * 10) + yuzler;
            int fark = sayi - tersSayi;
            Console.WriteLine("Sayının Tersi ile Arasındaki Fark....: " + fark);
            Console.ReadKey();

        }
    }
}
