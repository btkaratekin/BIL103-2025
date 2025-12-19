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
        /* Klavyeden girilen NxM bir matrisin içerisine rastgele atanan 3 basamaklı sayılardan tek olanları kırmızı, çift olanları beyaz olacak şekilde ekrana yazan programı oluşturunuz.
         */
        static void Main(string[] args)
        {
            Console.Write("Satır Sayısını Girin....:");
            int satirsay = int.Parse(Console.ReadLine());
            Console.Write("Sütun Sayısını Girin....:");
            int sutunsay = int.Parse(Console.ReadLine());
            int[,] sayilar = new int[satirsay, sutunsay];
            Random rnd = new Random();
            for (int i = 0; i < sayilar.GetLength(0); i++)
            {
                for (int j = 0; j < sayilar.GetLength(1); j++)
                {
                    sayilar[i, j] = rnd.Next(100, 1000);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < sayilar.GetLength(0); i++)
            {
                for (int j = 0; j < sayilar.GetLength(1); j++)
                {
                    if ((sayilar[i,j] %2)==0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor=ConsoleColor.Red;
                    }
                    Thread.Sleep(50);
                    Console.Write(sayilar[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
