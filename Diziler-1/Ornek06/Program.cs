using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek06
{
    internal class Program
    {
        /* Örnek: Fibonacci Dizisinin ilk 50 teriminiz ekrana yazdırdıktan sonra klavyeden girilen bir sayının fibonacci dizisinde olup olmadığını ekrana yazan programı oluşturunuz.
         */
        static void Main(string[] args)
        {
            ulong[] fibonacci = new ulong[50];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i]= fibonacci[i - 1] + fibonacci[i - 2];
            }
            Console.WriteLine("Fibonacci dizisinin ilk 50 terimi:");
            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine("{0}. Terim: {1}", i+1, fibonacci[i].ToString("N0"));
            }
            
            Console.Write("\n\nAradığınız Sayıyı Girin....: ");
            ulong terim =ulong.Parse( Console.ReadLine());
            int terno = 0;
            for (int i = 0; i < fibonacci.Length; i++)
            {
                if (terim == fibonacci[i])
                {
                    terno = i + 1;
                    break;
                }
            }
            if (terno==0)
            {
                Console.WriteLine("{0} Sayısı Fibonacci dizisinde bulunmamaktadır.", terim);
            }
            else
            {
                Console.WriteLine("{0} Sayısı Fibonacci dizisinin {1}. Sırasında bulunmaktadır.", terim,terno);
            }
            Console.ReadKey();
        }
    }
}
