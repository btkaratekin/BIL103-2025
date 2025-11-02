using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek10
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen bir sayının tek yada çift olduğunu ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * 
         * Algoritma
         * READ Sayi
         * IF (Sayi % 2==0) THEN
         *  WRITE "Sayi Çifttir"
         * ELSE
         *  WRITE "Sayi Tektir"
         * END IF
         */
        static void Main(string[] args)
        {
            //Not: Bu örnek daha önce de if-else yapısı ile çözüldü. Burada ise ternary (?) operatörü kullanarak örnek çözümlenmektedir. 
            Console.Title = "Tek Çift Sayı Bulma Uygulaması";
            Console.Write("Bir Sayı Girin.....:");
            int Sayi = int.Parse(Console.ReadLine());
            string Sonuc = (Sayi % 2 == 0) ? "Sayı Çifttir" : "Sayı Tektir";
            Console.WriteLine(Sonuc);
            Console.ReadKey();
        }
    }
}
