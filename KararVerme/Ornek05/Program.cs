using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek05
{
    /* Örnek: Klavyeden girilen 3 adet sayıdan en küçük olanı ekrana yazan algoritma ve programı oluşturunuz.
     * 
     * Algoritma
     * Ek=0
     * READ Sayi1,Sayi2, Sayi3
     * IF (Sayi1<Sayi2) THEN
     *   Ek=Sayi1
     * ELSE
     *   Ek=Sayi2
     * END IF
     * IF (Ek>Sayi3) THEN
     *   Ek=Sayi3
     * END IF
     * WRITE Ek
     * */
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double Ek = 0;
            Console.Write("1. Sayıyı Girin.....:");
            double Sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Sayıyı Girin.....:");
            double Sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3. Sayıyı Girin.....:");
            double Sayi3 = Convert.ToDouble(Console.ReadLine());
            if (Sayi1 < Sayi2)
            {
                Ek = Sayi1;
            }
            else
            {
                Ek = Sayi2;
            }
            if (Ek > Sayi3)
            {
                Ek = Sayi3;
            }
            Console.WriteLine("En Küçük Sayı: " + Ek);
            Console.ReadKey();
        }
    }
}
