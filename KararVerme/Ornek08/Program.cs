using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek08
{
    internal class Program
    {
        /* Örnek: Daha önceden saklanan Kullanıcı Adı ve Şifre bilgisine göre klavyeden girilen kullanıcı adı ve şifre bilgisi doğru ise ekrana "Giriş Başarılı", yanlış ise "Giriş Başarısız" yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * username="admin"
         * password="12345"
         * READ KullaniciAdi, Sifre
         * IF (KullaniciAdi==username AND Sifre==password) THEN
         *   WRITE "Giriş Başarılı"
         * ELSE
         *   WRITE "Giriş Başarısız"
         * END IF
         * */
        static void Main(string[] args)
        {
            Console.Title = "Kullanıcı Girişi";
            string username = "admin";
            string password = "12345";
            Console.Write("Kullanıcı Adını Girin.....:");
            string KullaniciAdi = Console.ReadLine();
            Console.Write("Şifreyi Girin.....:");
            string Sifre = Console.ReadLine();
            if ((KullaniciAdi == username) && (Sifre == password))
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız");
            }
            Console.ReadKey();
        }
    }
}
