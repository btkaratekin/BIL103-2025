using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek07
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen vize ve final notu değerine başarı notunu hesaplayıp,başarı durumunu ve  bu başarı notunun karşılığı olan harf notunu ekrana yazan algoritma ve programı oluşturunuz.
         * Not: Başarı Notu, Vizenin %40 'ı ile Finalin %60'ı toplanarak bulunur.
         * Bir öğrencinin bir dersten başarılı olabilmesi için başarı notunun 60 ve üzeri olması gerekir.
         * Harf Notu için kullanılacak aralıklar aşağıdaki gibidir:
                                                         * 0 <= F2  < 50
                                                         * 50 < F1  < 60
                                                         * 60 < C3  < 65
                                                         * 65 < C2  < 70
                                                         * 70 < C1  < 75
                                                         * 75 < B3  < 80
                                                         * 80 < B2  < 85
                                                         * 85 < B1  < 90
                                                         * 90 <= A   <=100
        
         * Algoritma
         * READ Vize, Final
         * BasariNotu = (Vize*0.4) + (Final*0.6)
         * IF (BasariNotu>=60) THEN
         *  WRITE "BAŞARILI"
         * ELSE
         *  WRITE "BAŞARISIZ"
         * END IF
         * IF (BasariNotu>=90) THEN
         *   WRITE "A"
         * ELSE IF (BasariNotu>=85) THEN
         *  WRITE "B1"
         * ELSE IF (BasariNotu>=80) THEN
         *   WRITE "B2"
         * ELSE IF (BasariNotu>=75) THEN
         *   WRITE "B3"
         * ELSE IF (BasariNotu>=70) THEN
         *   WRITE "C1"
         * ELSE IF (BasariNotu>=65) THEN
         *   WRITE "C2"
         * ELSE IF (BasariNotu>=60) THEN
         *   WRITE "C3"
         * ELSE IF (BasariNotu>=50) THEN
         *   WRITE "F1"
         * ELSE
         *   WRITE "F2"
         * END IF
         * */
        static void Main(string[] args)
        {
            Console.Title = "Başarı Notu Hesaplama";
            Console.Write("Vize Notunu Girin.....:");
            int vize = int.Parse(Console.ReadLine());
            Console.Write("Final Notunu Girin.....:");
            int final = int.Parse(Console.ReadLine());
            int basariNotu = (int)(vize * 0.4 + final * 0.6);
            Console.WriteLine("Başarı Notu: " + basariNotu);
            Console.Write("Başarı Durumu: ");
            if (basariNotu >= 60)
            {
                Console.WriteLine("BAŞARILI");
            }
            else
            {
                Console.WriteLine("BAŞARISIZ");
            }
            Console.Write("Harf Notu: ");
            if (basariNotu>=90)
            {
                Console.WriteLine("A");
            }
            else if (basariNotu>=85)
            {
                Console.WriteLine("B1");
            }
            else if (basariNotu>=80)
            {
                Console.WriteLine("B2");
            }
            else if (basariNotu>=75)
            {
                Console.WriteLine("B3");
            }
            else if (basariNotu>=70)
            {
                Console.WriteLine("C1");
            }
            else if (basariNotu>=65)
            {
                Console.WriteLine("C2");
            }
            else if (basariNotu>=60)
            {
                Console.WriteLine("C3");
            }
            else if (basariNotu>=50)
            {
                Console.WriteLine("F1");
            }
            else
            {
                Console.WriteLine("F2");
            }
            Console.ReadKey();
        }
    }
}
