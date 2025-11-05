using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek06
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen 5 adet öğrencinin vize ve final notundan başarı notunu elde edip, bu başarı notlarının ortalamasını ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * Toplam = 0
         * FOR X=1 TO 5 STEP 1
         *      READ Vize, Final
         *      BasariNotu = (Vize * 0.4) + (Final * 0.6)
         *      Toplam = Toplam + BasariNotu
         * END FOR
         * Ortalama = Toplam / 5
         * WRITE Ortalama
         */
        static void Main(string[] args)
        {
            double toplam = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i+". Öğrencinin Vize Notunu Girin..:");
                double vize = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(i+". Öğrencinin Final Notunu Girin.:");
                double final = Convert.ToDouble(Console.ReadLine());
                double basariNotu = (vize * 0.4) + (final * 0.6);
                toplam += basariNotu;
            }
            double ortalama = toplam / 5;
            Console.WriteLine("Öğrencilerin Başarı Notlarının Ortalaması: {0}", ortalama);
            Console.ReadKey();
        }
    }
}
