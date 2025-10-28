using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek06
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen bir sayının pozitif, negatif veya nötr olduğunu ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ Sayi
         * IF(Sayi>0) THEN
         *  WRITE "Pozitif"
         * ELSE IF(Sayi<0) THEN
         *  WRITE "Negatif"
         * ELSE
         *  WRITE "Sıfır"
         * END IF
         * */
        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin....: ");
            double Sayi = Convert.ToDouble(Console.ReadLine());

            if (Sayi > 0)
            {
                Console.WriteLine("Girdiğiniz Sayı Pozitiftir.");
            }
            else if (Sayi < 0)
            {
                Console.WriteLine("Girdiğiniz Sayı Negatiftir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz Sayı Sıfırdır.");
            }
            Console.ReadKey();
        }
    }
}
