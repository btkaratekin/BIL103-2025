using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek04
{
    internal class Program
    {
        /*Örnek: C# da object kullanımı Örnekleri*/
        static void Main(string[] args)
        {
            object sayi = 100; // object türünde değişken tanımlama ve int değer atama 
            object ondalikSayi = 99.99; // object türünde değişken tanımlama ve double değer atama
            object metin = "Merhaba Dünya"; // object türünde değişken tanımlama ve string değer atama
            object dogruMu = true; // object türünde değişken tanımlama ve bool değer atama
            object karakter = 'A'; // object türünde değişken tanımlama ve char değer atama
            
            //Unboxing İşlemleri

            int gerceksayi = Convert.ToInt32(sayi); // object türündeki sayi değişkenini int türüne dönüştürme unboxing
            double gercekondalik = Convert.ToDouble(ondalikSayi); // object türündeki ondalikSayi değişkenini double türüne dönüştürme unboxing
            string gercekmetin = Convert.ToString(metin); // object türündeki metin değişkenini string türüne dönüştürme unboxing
            bool gercekdogrumu = Convert.ToBoolean(dogruMu); // object türündeki dogruMu değişkenini bool türüne dönüştürme unboxing
            char gercekkarakter = Convert.ToChar(karakter); // object türündeki karakter değişkenini char türüne dönüştürme unboxing
        }
    }
}
