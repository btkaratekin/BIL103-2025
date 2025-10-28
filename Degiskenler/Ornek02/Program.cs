using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek02
{
    internal class Program
    {
        /* C# da Parse Metodu Kullanımı Örnekleri*/
        static void Main(string[] args)
        {
            int sayi = int.Parse("100"); // String ifadeyi int türüne dönüştürme
            double ondalikSayi = double.Parse("99.99"); // String ifadeyi double türüne dönüştürme
            bool durum = bool.Parse("true"); // String ifadeyi bool türüne dönüştürme
            sbyte kucukSayi = sbyte.Parse("120"); // String ifadeyi sbyte türüne dönüştürme
            char karakter = char.Parse("X");// String ifadeyi char türüne dönüştürme
            int veri = int.Parse(Console.ReadLine()); // Konsoldan girilen string ifadeyi int türüne dönüştürme
            float ondaliklisayi = float.Parse(Console.ReadLine()); // Konsoldan girilen string ifadeyi float türüne dönüştürme
        }
    }
}
