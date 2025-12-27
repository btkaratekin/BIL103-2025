using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek10
{
    internal class Program
    { 
        /* Örnek: Rastgele büyük harflerden oluşan 10000 elemanlı harfler dizisi oluşturulduktan sonra dizi ekrana yazdırılırken arka arkaya  M,Y ve O harfleri denk geldiğinde bu harfleri farklı bir renkte ekrana yazan programı oluşturunuz. 
         */

        static void Main(string[] args)
        {
            Random rnd = new Random();
            char[] harfler = new char[10000];
            for (int i = 0; i < harfler.Length; i++)
            {
                harfler[i] = Convert.ToChar(rnd.Next(65, 91));
            }
            for (int i = 0; i < harfler.Length - 2; i++)
            {
                if ((harfler[i] == 'M') && (harfler[i + 1] == 'Y') && (harfler[i + 2] == 'O'))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(harfler[i] + "" + harfler[i + 1] + "" + harfler[i + 2]);
                    i += 2;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(harfler[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
