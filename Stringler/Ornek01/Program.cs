using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen bir metni ekrana ters yazan programı oluşturunuz.
         */
        static void Main(string[] args)
        {
            Console.Write("Bir metin giriniz: ");
            string metin = Console.ReadLine();
            Console.Write("Girdiğiniz Metnin Ters Yazılışı: ");
            for (int i = metin.Length-1; i >=0; i--)
            {
                Console.Write(metin[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
