using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek03
{
    internal class Program
    {
        /* Aşağıda Çankırı ilinin 11.12.2025 tarihinde beklenen 24 saatlik sıcaklık değerleri bir dizi
         * içerisinde verilmiştir. 
         * 01:00 - -3.5          05:00 - -1.5         09:00 - +2.5      13:00 - +6.0      17:00 - +7.0      21:00 - +0.0 
         * 02:00 - -3.0          06:00 - -1.0         10:00 - +3.0      14:00 - +8.0      18:00 - +6.5      22:00 - -0.5
         * 03:00 - -2.5          07:00 - -1.0         11:00 - +3.5      15:00 - +9.0      19:00 - +3.0      23:00 - -1.0
         * 04:00 - -2.0          08:00 - +1.0         12:00 - +5.0      16:00 - +8.0      20:00 - +1.5      00:00 - -2.0
         * 
         * Bu bilgilere göre aşağıdaki sorulara yanıt veren programı oluşturunuz.
         * 1. Günün en yüksek ve en düşük sıcaklık değerlerini saatleri ile birlikte ekrana yazdırınız.
         * 2. Günün sıcaklık ortalamasını ekrana yazdırınız.
         * 3. En düşük sıcaklık ile en yüksek sıcaklık değeri arasındaki toplam saat farkını ekrana yazdırınız. 
         */
        static void Main(string[] args)
        {
                        double[] sicakliklar = new double[24] { -3.5, -3.0, -2.5, -2.0, -1.5, -1.0, +1.0, +2.5, +3.0, +3.5, +5.0, +6.0, +7.0, +8.0, +6.5, +5.0, +4.0, +3.0, +2.0, +1.5, +1.0, +0.0, -0.5, -1.0 };
            double enYuksek = sicakliklar[0];
            double enDusuk = sicakliklar[0];
            int enYuksekSaat = 0;
            int enDusukSaat = 0;
            double toplam = 0;
            for (int i = 0; i < sicakliklar.Length; i++)
            {
                if (sicakliklar[i] > enYuksek)
                {
                    enYuksek = sicakliklar[i];
                    enYuksekSaat = i;
                }
                if (sicakliklar[i] < enDusuk)
                {
                    enDusuk = sicakliklar[i];
                    enDusukSaat = i;
                }
                toplam += sicakliklar[i];
            }
            double ortalama = toplam / sicakliklar.Length;
            int saatFarki = Math.Abs(enYuksekSaat - enDusukSaat);
            Console.WriteLine("Günün en yüksek sıcaklığı: " + enYuksek + "°C saat: " + enYuksekSaat + ":00");
            Console.WriteLine("Günün en düşük sıcaklığı: " + enDusuk + "°C saat: " + enDusukSaat + ":00");
            Console.WriteLine("Günün sıcaklık ortalaması: " + Math.Round(ortalama) + "°C");
            Console.WriteLine("En düşük ve en yüksek sıcaklık arasındaki saat farkı: " + saatFarki + " saat");
            Console.ReadKey();

        }
    }
}
