using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek08
{
    internal class Program
    {
        /*Örnek: Klavyeden girilen 2 adet sayının iki kare toplamını
         * a^2 + b^2 biçiminde 
         * (a+b)^2 - 2ab biçiminde
         * (a-b)^2 + 2ab biçiminde
         * hesaplayarak ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ s1,s2
         * kareToplam1 = s1*s1 + s2*s2
         * kareToplam2 = (s1 + s2)*(s1 + s2) - 2*s1*s2
         * kareToplam3 = (s1 - s2)*(s1 - s2) + 2*s1*s2
         * WRITE kareToplam1,kareToplam2,kareToplam3
         */
        static void Main(string[] args)
        {
            Console.Write("1. Sayıyı Girin.....:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Girin.....:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int kareToplam1 = (s1 * s1) + (s2 * s2);
            int kareToplam2 = (s1 + s2) * (s1 + s2) - (2 * s1 * s2);
            int kareToplam3 = (s1 - s2) * (s1 - s2) + (2 * s1 * s2);
            Console.WriteLine("a^2 + b^2 Biçiminde Toplam....: " + kareToplam1);
            Console.WriteLine("(a + b)^2 - 2ab Biçiminde Toplam: " + kareToplam2);
            Console.WriteLine("(a - b)^2 + 2ab Biçiminde Toplam: " + kareToplam3);
            Console.ReadKey();
        }
    }
}
