using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek08
{
    internal class Program
    {
        /*Örnek: Klavyeden girilen 10 adet ili alfabetik düzende (A'dan Z'ye) ekrana yazan programı oluşturunuz.
         */
        static void Main(string[] args)
        {
            string[] iller = new string[10];
            for (int i = 0; i < iller.Length; i++)
            {
                Console.Write("{0}. İli Girin....:",i);
                iller[i] = Console.ReadLine();
            }
            Array.Sort(iller);
            Console.WriteLine("\nAlfabetik Düzende İller Listesi");
            for (int i = 0; i < iller.Length; i++)
            {
                Console.WriteLine(iller[i]);
            }
            Console.ReadKey();
        }
    }
}
