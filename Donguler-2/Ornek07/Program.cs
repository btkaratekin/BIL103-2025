using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek07
{
    /*Örnek:1 ile 100 arasında Hafızada tutulan rastgele bir sayıyı kullanıcıdan girişler alarak bulmaya çalıştığı ve sayı bulunduğunda kaçıncı tahminde sayının bulunduğunu ekrana yazan algoritma ve programı oluşturunuz.
     * 
     * Algoritma
     * Sayi=RANDOM(100)+1
     * durum=true
     * tahminSayisi=0
     * WHILE (durum==true) DO
     *      READ Tahmin
     *      tahminSayisi=tahminSayisi+1
     *      IF (Tahmin<Sayi) THEN
     *          WRITE "Daha Büyük Bir Sayı Giriniz."
     *      ELSE IF (Tahmin>Sayi) THEN
     *          WRITE "Daha Küçük Bir Sayı Giriniz."
     *      ELSE
     *          WRITE tahminSayisi
     *          durum=false
     *      END IF
     * END WHILE
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Sayi = rnd.Next(100) + 1;
            bool durum = true;
            int tahminSayisi = 0;
            Console.WriteLine("1 ile 100 Arasında Bir Sayı Tahmin Ediniz.");
            while (durum == true)
            {
                Console.Write("Tahmininiz..: ");
                int Tahmin = Convert.ToInt32(Console.ReadLine());
                tahminSayisi = tahminSayisi + 1;
                if (Tahmin < Sayi)
                {
                    Console.WriteLine("Daha Büyük Bir Sayı Giriniz.");
                }
                else if (Tahmin > Sayi)
                {
                    Console.WriteLine("Daha Küçük Bir Sayı Giriniz.");
                }
                else
                {
                    Console.WriteLine("Tebrikler Doğru Tahmin.");
                    Console.WriteLine("Tahmin Sayınız..: {0}", tahminSayisi);
                    durum = false;
                }
            }
            Console.ReadKey();
        }
    }
}
