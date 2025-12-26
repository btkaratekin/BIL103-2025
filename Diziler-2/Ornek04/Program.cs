using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ornek04
{
    internal class Program
    {
        /* 
         * Örnek: NxN  bir matrisi rastgele S ve O harfleriyle doldurduktan sonra, sistem tarafından yatay da ve dikeyde oluşan SOS dizelerini bulup ekrana yazdıran programı oluşturunuz.
         */
        static void Main(string[] args)
        {
            Console.Title = "SOS Oyunu";
            Console.Write("Matris Boyutunu Giriniz....:");
            int boyut = int.Parse(Console.ReadLine());
            Console.WriteLine();
            char[,] matris = new char[boyut, boyut];
            Random rnd = new Random();
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (rnd.Next(2) == 0)
                    {
                        matris[i, j] = 'S';
                    }
                    else
                    {
                        matris[i, j] = 'O';
                    }
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Write("\nMatristeki Yatay ve Dikey SOS Dizelerini Bulmak İçin Bir Tuşa Basın...");
            Console.ReadKey();
            bool[,] kontrolmatris = new bool[boyut, boyut];
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    // Yatay Kontrol
                    if (j <= matris.GetLength(1) - 3)
                    {
                        if (matris[i, j] == 'S' && matris[i, j + 1] == 'O' && matris[i, j + 2] == 'S')
                        {
                            kontrolmatris[i, j] = true;
                            kontrolmatris[i, j + 1] = true;
                            kontrolmatris[i, j + 2] = true;
                        }
                    }
                    // Dikey Kontrol
                    if (i <= matris.GetLength(0)-3)
                    {
                        if (matris[i, j] == 'S' && matris[i + 1, j] == 'O' && matris[i + 2, j] == 'S')
                        {
                            kontrolmatris[i, j] = true;
                            kontrolmatris[i + 1, j] = true;
                            kontrolmatris[i + 2, j] = true;
                        }
                    }
                }

            }
            Console.SetCursorPosition(0, 2);
            for (int i = 0; i < kontrolmatris.GetLength(0); i++)
            {
                for (int j = 0; j < kontrolmatris.GetLength(1); j++)
                {
                    if (kontrolmatris[i, j])
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                       
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        
                    }
                    Console.Write(matris[i, j] + " ");
                    Thread.Sleep(25);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
