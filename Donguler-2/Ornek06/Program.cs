using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek06
{
    internal class Program
    {
        /* Örnek: Klavyeden girilen kullanıcı adı ve şifre ile bir uygulamaya giriş yaparken kullanıcı adı ya da şifre boş geçildiği sürece yeniden girdi alan ancak 3 defa kullanıcı adı ve şifre yanlış girildiğinde uygulamayı sonlandıran algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * Kadi ="BIL",Sifre="1234",basdeneme=3 //basdeneme --> başarısız deneme
         * WHILE (basdeneme>0)
         *      READ username
         *      READ password
         *      IF(username=="" OR password=="") THEN
         *          CONTINUE
         *      ELSE IF(username==Kadi AND password==Sifre) THEN
         *          WRITE "Giriş başarılı."
         *          BREAK
         *      ELSE
         *          WRITE "Giriş başarısız."
         *          basdeneme=basdeneme-1
         *      END IF
         * END WHILE
         */
        static void Main(string[] args)
        {
            string kadi = "BIL", sifre = "1234";
            int basdeneme = 3; //basdeneme --> başarısız deneme
            while (basdeneme > 0)
            {
                Console.Write("Kullanıcı Adı..: ");
                string username = Console.ReadLine();
                Console.Write("Şifre..: ");
                string password = Console.ReadLine();
                if (username == "" || password == "")
                {
                    Console.WriteLine("Kullanıcı Adı ya da Şifre Boş Geçilemez.");
                    continue;
                }
                else if (username == kadi && password == sifre)
                {
                    Console.WriteLine("Giriş başarılı.");
                    break;
                }
                else
                {
                    Console.WriteLine("Giriş başarısız.");
                    basdeneme = basdeneme - 1;
                }
                Console.WriteLine("Kalan Başarısız Deneme Hakkınız..: {0}", basdeneme);
            }
            Console.WriteLine(Math.Cos(60));
            Console.ReadKey();
        }
    }
}
