using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek05
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen bir metnin içerisindeki ünlü ve ünsüz harfleri sayan programı oluşturunuz.
         */
        static void Main(string[] args)
        {
            Console.Write("Bir Metin Girin..:");
            string metin = Console.ReadLine();
            string unluler = "AEIİOÖUÜaeıioöuü";
            char[] unluharfler  = unluler.ToCharArray();
            string noktalamalar = " ,.!?;:'\"-()[]{}<>@#$%^&*`~\\/|+=_";
            char[] noktalamaListe= noktalamalar.ToCharArray();
            int unlusay = 0,unsuzsay=0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (Array.IndexOf(unluharfler, metin[i])!=-1)
                {
                    unlusay++;
                }
                else if (Array.IndexOf(noktalamaListe, metin[i])==-1)
                {
                    unsuzsay++;
                }
            }
            Console.WriteLine("Ünlü Harf Sayısı: {0}", unlusay);
            Console.WriteLine("Ünsüz Harf Sayısı: {0}", unsuzsay);
            Console.ReadKey();
        }
    }
}
