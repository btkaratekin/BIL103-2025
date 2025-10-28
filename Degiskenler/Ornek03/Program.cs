using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek03
{
    internal class Program
    {
        /*Convert Sınıfı Metodları Kullanımı Örnekleri*/
        static void Main(string[] args)
        {
            int sayi = Convert.ToInt32("200"); // String ifadeyi int türüne dönüştürme
            double ondalikSayi = Convert.ToDouble("150.75"); // String ifadeyi double türüne dönüştürme
            bool durum = Convert.ToBoolean("false"); // String ifadeyi bool türüne dönüştürme
            byte kucukSayi = Convert.ToByte("255"); // String ifadeyi byte türüne dönüştürme
            char karakter = Convert.ToChar("Z"); // String ifadeyi char türüne dönüştürme
            int veri = Convert.ToInt32(Console.ReadLine()); // Konsoldan girilen string ifadeyi int türüne dönüştürme
            float ondaliklisayi = Convert.ToSingle(Console.ReadLine()); // Konsoldan girilen string ifadeyi float türüne dönüştürme
        }
    }
}
