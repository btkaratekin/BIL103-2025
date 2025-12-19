using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek03
{
    internal class Program
    {
        /* N x M Bir matriste rastgele atanan büyük harflerden ünlü olanları kırmızı, ünsüz olanları beyaz olacak şekilde tablo biçiminde ekrana yazan programı oluşturunuz.
         */
        static void Main(string[] args)
        {
            char[] Alfabe = new char[29] {'A','B','C','Ç','D','E','F','G','Ğ','H','I','İ','J', 'K','L','M','N','O','Ö','P','R','S','Ş','T','U','Ü','V','Y','Z'};
            Console.Write("Satır Sayısını Girin....:");
            int satirsay = int.Parse(Console.ReadLine());
            Console.Write("Sütun Sayısını Girin....:");
            int sutunsay = int.Parse(Console.ReadLine());
            char[,] harfler = new char[satirsay, sutunsay];
            Random rnd = new Random();
            for (int i = 0; i < harfler.GetLength(0); i++)
            {
                for (int j= 0;  j< harfler.GetLength(1); j++)
                {
                    harfler[i, j] = Convert.ToChar(Alfabe[rnd.Next(29)]);
                }
            }
            char[] unluharfler = new char[8] {'A','E','I','İ','O','Ö','U','Ü'};
            for (int i = 0; i < harfler.GetLength(0); i++)
            {
                for (int j = 0; j < harfler.GetLength(1); j++)
                {
                    if (Array.IndexOf(unluharfler, harfler[i,j])==-1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(harfler[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
