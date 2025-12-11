using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek05
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen terim sayısı kadar fibonacci serisinin elemanlarını bir dizi içerisinde saklayarak ekrana yazdırınız. */
        static void Main(string[] args)
        {
            Console.Write("Fibonacci serisi için terim sayısını giriniz: ");
            int terimSayisi = int.Parse(Console.ReadLine());
            long[] fibonacci = new long[terimSayisi];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < terimSayisi; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            Console.WriteLine("Fibonacci serisi:");
            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine("{0}. Terim: {1}", i, fibonacci[i]);
            }
            Console.ReadKey();
        }
    }
}
