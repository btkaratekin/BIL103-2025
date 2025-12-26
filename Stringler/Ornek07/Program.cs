using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek07
{
    internal class Program
    {
        /* Palindrom, hem sağ taraftan hem de sol taraftan okunduğunda aynı olan kelime veya kelime gruplarıdır. Örneğin mum, ada, yapay, kazak, küçük, neden, niçin gibi kelimelerle “ey edip adanada pide ye” cümlesi birer palindrom örneğidir.
         * 
         * Örnek: Klavyeden girilen bir metnin palindrom olup olmadığını ekrana yazan programı oluşturunuz.
         
         */
        static void Main(string[] args)
        {
            Console.Write("Bir Metin Girin..:");
            string metin = Console.ReadLine();
            string duzmetin = metin.ToUpper();
            string tersmetin = "";
            for (int i = duzmetin.Length-1; i >=0; i--)
            {
                tersmetin += duzmetin[i];
            }
            Console.WriteLine("{0} - {1}",duzmetin,tersmetin);
            if (String.Compare(duzmetin,tersmetin)==0)
            {
                
                Console.WriteLine("Girilen Metin Palindromdur.");
            }
            else
            {
                Console.WriteLine("Girilen Metin Palindrom Değildir.");
            }
            Console.ReadKey();

        }
    }
}
