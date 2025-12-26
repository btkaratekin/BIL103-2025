using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek04
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen bir metnin içerisinde hangi harften kaç tane olduğunu ekrana yazan programı oluşturunuz.
         */
        static void Main(string[] args)
        {
            Console.Write("Bir Metin Girin...:");
            string metin = Console.ReadLine();
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz";
            char[] alfabe = harfler.ToCharArray();
            for (int i = 0; i < alfabe.Length; i++)
            {
                int sayac = 0;
                for (int j = 0; j < metin.Length; j++)
                {
                    if (alfabe[i] == metin[j])
                    {
                        sayac++;
                    }
                }
                if (sayac>0)
                {
                    Console.WriteLine("{0}: {1}", alfabe[i],sayac);
                }
            }
            Console.ReadKey();
        }
    }
}
