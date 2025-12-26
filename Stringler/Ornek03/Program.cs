using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek03
{
    internal class Program
    {
        /* Örnek:  Klavyeden girilen bir cümlenin her bir kelimesinin ilk harfini büyük harf yapan programı oluşturunuz.
         */
        static void Main(string[] args)
        {
            Console.Write("Bir Metin Girin...:");
            string metin = Console.ReadLine();
            string[] kelimeler = metin.Split(' ');
            for (int i = 0; i < kelimeler.Length; i++)
            {
                string kelime = kelimeler[i];
                for (int j = 0; j <kelime.Length; j++)
                {
                   kelime = Convert.ToString(kelime[0]).ToUpper() + kelime.Substring(1);
                }
                Console.Write(kelime + " ");
            }
            Console.ReadKey();
        }
    }
}
