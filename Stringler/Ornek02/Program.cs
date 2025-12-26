using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ornek02
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen bir metni akardeon şeklinde yazan programı oluşturunuz.
         */
        static void Main(string[] args)
        {
            Console.Write("Bir Metin Girin...:");
            string metin = Console.ReadLine();
            for (int i = 0; i < metin.Length; i++)
                {
                for (int j = 0; j <= i; j++)
                {
                    Thread.Sleep(25);
                    Console.Write(metin[j]);
                }
                Console.WriteLine();
            }
            for (int i = metin.Length; i >= 0; i--)
            {
                for (int j = 0; j <i ; j++)
                {
                    Console.Write(metin[j]);
                    Thread.Sleep(25);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
