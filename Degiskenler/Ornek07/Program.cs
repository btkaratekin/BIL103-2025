using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek07
{
    internal class Program
    {
        /*Örnek: Klavyeden çevresi girilen bir dairenin alanını ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * Pi=3.14
         * READ Cevre
         * yaricap = Cevre / (2 * Pi)
         * Alan = Pi * yaricap * yaricap
         * WRITE Alan
         */
        static void Main(string[] args)
        {
            double Pi = 3.14;// İleriki Haftalarda Math.PI olarak kullamılacaktır.
            Console.Write("Dairenin Çevresini Giriniz: ");
            double Cevre = Convert.ToDouble(Console.ReadLine());
            double yaricap = Cevre / (2 * Pi);
            double Alan = Pi * yaricap * yaricap;
            Console.WriteLine("Dairenin Alanı: " + Alan);
            Console.ReadKey();
        }
    }
}
