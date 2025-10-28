using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek09
{
    internal class Program
    {
        /* Örnek: Bir ziyaretçinin ücretsiz müze giriş kartı alabilmesi için yapması gerekenler şunlardır. 
         * Ziyaretçi 18 yaşından küçükse veya 65 yaşından büyükse ücretsiz giriş kartı alabilir.
         * Ziyaretçi öğrenci ise ücretsiz giriş kartı alabilir.
         * Ziyaretçi engelli ise ücretsiz giriş kartı alabilir.
         * 
         * Buna göre klavyeden girilen yaş, öğrenci durumu ve engelli durumu bilgilerine göre ziyaretçinin ücretsiz müze giriş kartı alıp alamayacağını ekrana yazan algoritma ve programı oluşturunuz.
         * 
         * Algoritma
         * READ Yas
         * READ OgrenciDurum
         * READ EngelliDurum
         * IF (((Yas<18) OR (Yas>65)) OR (OgrenciDurum==TRUE) OR (EngelliDurum==TRUE)) THEN
         *  WRITE "Ücretsiz Giriş Kartı Alabilir"
         * ELSE
         *  WRITE "Ücretsiz Giriş Kartı Alamaz"
         * END IF
         */
        static void Main(string[] args)
        {
            Console.Title = "Ücretsiz Müze Giriş Kartı Alma Uygulaması";
            Console.Write("Yaşınızı Girin.........:");
            int Yas = int.Parse(Console.ReadLine());
            Console.Write("Öğrenci misiniz? (E/H).:");
            char OgrenciCevap = char.Parse(Console.ReadLine());
            Console.Write("Herhangi bir Engel Durumunuz Var mı (E/H).:");
            char EngelliCevap = char.Parse(Console.ReadLine());
            if (((Yas<18) || (Yas>65)) ||(OgrenciCevap=='E')||(EngelliCevap=='E'))
            {
                Console.WriteLine("Ücretsiz Müze Kartı Alabilirsiniz..");
            }
            else
            {
                Console.WriteLine("Ücretsiz Müze Kartı Alamazsınız.");
            }
            Console.ReadKey();
        }
    }
}
