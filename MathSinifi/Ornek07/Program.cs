using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek07
{
    internal class Program
    {
        /*Örnek: 0 ile 360 derece arasında 15 er decere artarak açı değerlerini ve bu açıların sinüs ve kosinüs değerlerini ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * FOR X=0 TO 360 STEP 15
         *        WRITE SIN(X * PI/180)
         *        WRITE COS(X * PI/180)
         * END FOR
         */
        static void Main(string[] args)
        {
            Console.Title = "Açıların Sinüs ve Kosinüs Değerleri";
            for (int x = 0; x <= 360; x += 15)
            {
                Console.WriteLine("{0}°: Sinüs = {1},\t Kosinüs = {2}", x, Math.Sin(x * Math.PI / 180).ToString("F2"), Math.Cos(x * Math.PI / 180).ToString("F2"));
            }
            Console.ReadKey();
        }
    }
}
