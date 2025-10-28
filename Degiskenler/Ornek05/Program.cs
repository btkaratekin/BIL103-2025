using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek05
{
    internal class Program
    {
        /*Örnek: Klavyeden girilen 2 adet sayının toplamını ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ Sayi1,Sayi2
         * Toplam=Sayi1+Sayi2
         * WRITE Toplam
         */
        static void Main(string[] args)
        {  
            Console.Write("1. Sayıyı Girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam); // Burada + operatörü aritmetiksel işlem için değil, string birleştirme işlemi için kullanılmıştır.
            Console.ReadKey();
        }
    }
}
