using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek06
{
    internal class Program
    {
        /*Örnek: Klavyeden kenar değeri girilen bir karenin çevresini ve alanını ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * 
         * READ kenar
         * Cevre = kenar * 4
         * Alan = kenar * kenar
         * WRITE Cevre, Alan
         */
        static void Main(string[] args)
        {
            Console.Write("Kenar uzunluğunu girin: ");
            int kenar = Convert.ToInt32(Console.ReadLine());
            int cevre = kenar * 4;
            int alan = kenar * kenar;
            Console.WriteLine("Karenin çevresi: " + cevre);
            Console.WriteLine("Karenin alanı: " + alan);
            Console.ReadKey();
        }
    }
}
