using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek11
{
    internal class Program
    {
        /*
         * Örnek: Bir banka müşterisinin bankadan kredi alabilmesi için aşağıdaki şartları sağlaması gerekmektedir.
         *      
         *      - Müşteri devlet memuru değil ise bir kefil göstermek zorundadır. 
         *      - Müşterinin devam eden bir kredi ödemesi var ise kredi verilemez.
         *      - Müşteri banka müşterisi ise, ödeyeceği toplam borç (Anapara + KrediTutarı) üzerinden %10 indirim uygulanır.
         *      
         *      Ayrıca Bankadan alınabilecek kredi türleri şunlardır.
         *      - İhtiyaç Kredisi: Aylık Faiz Oranı: 3.29% Maximum Vade 24 Ay
         *      - Konut Kredisi  : Aylık Faiz Oranı: 1.29% Maximum Vade 120 Ay
         *      - Taşıt Kredisi  : Aylık Faiz Oranı: 2.49% Maximum Vade 60 Ay
         *      
         *      Ve Banka, müşteriye ihtiyaç kredisi için en fazla maaşının 12, taşıt kredisinde maaşının 24, konut kredisinde ise 36 katına kadar kredi verebilir.
         *      
         *      Toplam ödenecek faiz tutarı hesaplanırken kullanılacak formül:  Toplam Faiz=Ana Para×Aylık Faiz Oranı×Vade
         *      Müşterinin ödeyeceği aylık tutarın hesaplanmasında ise kullanılacak formül: Aylık Tutar=(Ana Para+Toplam Faiz) / Vade dir.
         *      
         *      Bu kriterlere göre Klavyeden girilen Maaş tutarı, Devlet Memuru durumu, Kefil durumu, Devam eden kredi durumu ve Banka Müşterisi olup olmadığı bilgileri alınarak kişinin kredi alıp alamayacağını ve alabiliyorsa gireceği toplam kredi tutarı, ay türünden vade süresi ve kredi türüne göre aylık ödeyeceği tutarı hesaplayan algoritmayı ve programı oluşturunuz.
         *      
         *      
         * Algoritma
         * MaxKredi=0
         * READ Maas
         * READ DevletMemuru
         * READ KefilDurumu
         * READ DevamEdenKredi
         * READ BankaMusterisi
         * IF (DevamEdenKredi=='H') AND ((DevletMemuru=='E') OR (KefilDurumu=='E')) THEN
         *      READ KrediTuru
         *      READ ToplamKredi
         *      READ AylikVade
         *      MaxTutar = Maas * 36
         *     IF (MaxTutar<ToplamKredi) THEN
         *          IF (KrediTuru==1)
         *               IF (AylikVade<=24) THEN
         *                  MaxOdenecekTutar = ToplamKredi + ((ToplamKredi * 3.29 * AylikVade)/ 100)
         *                  AylikTutar = MaxOdenecekTutar / AylikVade
         *               ELSE
         *                  WRITE "İhtiyaç Kredisi İçin Maximum Vade 24 Aydır."
         *               END IF
         *          ELSE IF (KrediTuru==2)
         *               IF (AylikVade<=120) THEN
         *                  MaxOdenecekTutar = ToplamKredi + ((ToplamKredi * 1.29 * AylikVade)/ 100)
         *                  AylikTutar = MaxOdenecekTutar / AylikVade
         *               ELSE
         *                  WRITE "Konut Kredisi İçin Maximum Vade 120 Aydır."
         *               END IF
         *               ELSE
         *                  IF (AylikVade<=60) THEN
         *                      MaxOdenecekTutar = ToplamKredi + ((ToplamKredi * 2.49 * AylikVade)/ 100)
         *                      AylikTutar = MaxOdenecekTutar / AylikVade
         *                  ELSE
         *                      WRITE "Taşıt Kredisi İçin Maximum Vade 60 Aydır."
         *                  END IF
         *               END IF
         *     ELSE
         *          WRITE "Kredi Tutarı Maaşınızın 36 Katından Fazla Olamaz."
         *     END IF
         *           
         *          
         *           IF(BankaMusterisi=='E') THEN
         *                  MaxOdenecekTutar = MaxOdenecekTutar - (MaxOdenecekTutar * 10 / 100)     
         *           END IF
         *           WRITE MaxOdenecekTutar
         *           IF (MaxOdenecekTutar>Maas*36) THEN
         *                 
         *                  WRITE "Kredi Tutarı Maaşınızın 36 Katından Fazla Olamaz."
         *           if
         * ELSE
         *         WRITE "Kredi Kullanamazsınız."
         * END IF
         */
        static void Main(string[] args)
        {
        }
    }
}
