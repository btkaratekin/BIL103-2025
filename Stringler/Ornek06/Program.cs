using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek06
{
    internal class Program
    {
        /*Örnek: Klavyeden girilen kullanıcı adı ve şifrenin boş geçilemeyeceğini ekrana yazan programı oluşturunuz.
        
         */
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı Adı Girin...:");
            string kullaniciadi = Console.ReadLine();
            Console.Write("Şifre Girin...:");
            string sifre = Console.ReadLine();
            if (string.IsNullOrEmpty(kullaniciadi) || string.IsNullOrEmpty(sifre))
            {
                Console.WriteLine("Kullanıcı Adı ve Şifre Boş Geçilemez...");
            }
            else
            {
                Console.WriteLine("Kullanıcı Adı ve Şifre Kabul Edildi...");
            }
            Console.ReadKey();
        }
    }
}
