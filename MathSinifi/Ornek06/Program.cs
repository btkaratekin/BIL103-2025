using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek06
{
    internal class Program
    {
        /*Örnek: Klavyeden dik kenarları girilen bir dik üçgenin hipotenüsünü ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ A
         * READ B
         * Hipotenus=SQRT(POW(DikKenar1,2)+POW(DikKenar2,2))
         * WRITE Hipotenus
         */
        static void Main(string[] args)
        {
            Console.Title = "Dik Üçgen Hipotenüs Hesabı";
            Console.Write("1. Dik Kenarı Girin: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Dik Kenarı Girin: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double hipotenus = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Hipotenüs: " + hipotenus);
            Console.ReadKey();
        }
    }
}
