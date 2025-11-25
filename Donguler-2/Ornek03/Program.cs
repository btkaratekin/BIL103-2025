using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek03
{
    internal class Program
    {
        /*Örnek: Klavyeden negatif sayı girilinceye kadar sayı girişi yapan ve negatif sayı girildiğinde o ana kadar girilen pozitif sayıların aritmetik ortalamasını ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * Toplam=0,Padet=0
         * durum=true
         * WHILE (durum==true) DO
         *      READ Sayi
         *      IF (Sayi>=0) THEN
         *          Toplam = Toplam + Sayi
         *          Padet=Padet + 1
         *      ELSE
         *          durum=false
         *      END IF
         * END WHILE
         * WRITE Toplam/Padet
         */
        static void Main(string[] args)
        {
            int toplam = 0, padet = 0;
            bool durum = true;
            while (durum == true)
            {
                Console.Write("Sayı Giriniz..: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi >= 0)
                {
                    toplam = toplam + sayi;
                    padet = padet + 1;
                }
                else
                {
                    durum = false;
                }
            }
            Console.WriteLine("Negatif Sayı Girilinceye Kadar Girilen Pozitif Sayıların Aritmetik Ortalaması {0} dir", toplam / padet);
            Console.ReadKey();
        }
    }
}
