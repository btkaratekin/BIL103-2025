using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek04
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen ad soyad ve cinsiyet verisine göre ekrana Hoşgeldiniz Bay / Bayan ... yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ AdSoyad
         * READ Cinsiyet
         * IF (Cinsiyet=="E") THEN
         *   WRITE "Hoşgeldiniz Bay " + AdSoyad
         * ELSE
         *   WRITE "Hoşgeldiniz Bayan " + AdSoyad
         * END IF
         * */
        static void Main(string[] args)
        {
            Console.Write("Ad Soyad Girin...:");
            string AdSoyad = Console.ReadLine();
            Console.Write("Cinsiyet (E/K) Girin...:");
            char Cinsiyet = char.Parse(Console.ReadLine());
            if (Cinsiyet == 'E')
            {
                Console.WriteLine("Hoşgeldiniz Bay " + AdSoyad);
            }
            else
            {
                Console.WriteLine("Hoşgeldiniz Bayan " + AdSoyad);
            }
            Console.ReadKey();
        }
    }
}
