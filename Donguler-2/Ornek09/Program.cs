using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ornek09
{
    internal class Program
    {/* Örnek: Bir balıkçının gün boyunca avlanmayı bitirmesi için toplamda en az 10 kg balık tutması gerekmektedir. Balıkçı 15 dakikada    rastgele 0 ile 3 arası balık tutmaktadır. Ve bu tuttuğu balıkların ağırlıkları da rastgele 150 gr ile 2 kg arasında değişmektedir. Buna göre balıkçı toplamda gün boyu en az 10 kilo balık tutabilmesi için avlanma süresini ve tuttuğu balıkların ağırlıklarını ve adetini ekrana yazan algoritma ve programı oluşturunuz.
      * Not: Küçük Orta veya Büyük Balık Tutma Olasılıkları Aşağıdaki oranlara göre belirlenecektir.
      * Küçük Balık (150 gr - 400 gr)  %70
      * Orta Balık (401 gr - 1200 gr) %25
      * Büyük Balık (1201 gr - 2000 gr) %5
      * 
      * Algoritma
      * Baliksay=0
      * Toplamkg = 0
      * Sayac=1
      * WHILE(Toplamkg <10) DO
      *         WRITE Sayac ". 15 Dakika"
      *         adet=RANDOM(4)
      *         IF(adet==0) THEN
      *             WRITE "Bu Sürede Balık Tutulamadı."
      *         ELSE
      *             FOR X=1 TO adet STEP 1
      *                 Olasılık=RANDOM(100)+1
      *                 IF(Olasılık<70) THEN
      *                     Gram=RANDOM(150,400)
      *                 ELSE IF(Olasılık<95) THEN
      *                     Gram=RANDOM(400,1200)
      *                 ELSE
      *                     Gram=RANDOM(120,2000)
      *                 END IF
      *                 Toplamkg=Toplamkg+Gram
      *                 WRITE X ". Balık Ağırlığı..: " Gram " gr"
      *             END FOR
      *         END IF
      *         Baliksay=Baliksay+adet
      *         Sayac=Sayac+1
      *         WRITE ToplamKg
      * END WHILE
      * WRITE "Avlanma Sonlandı"
      * WRITE BalikSay
      * WRITE Toplamkg/1000
      */
        static void Main(string[] args)
        {
            int baliksay = 0, sayac = 1;
            double toplamkg = 0;
            Random rnd = new Random();
            while (toplamkg < 10000)
            {
                Console.WriteLine(sayac + ". 15 Dakikada");
                int adet = rnd.Next(4);
                if (adet==0)
                {
                    Console.WriteLine("Bu Turda Balık Tutulamadı.");
                }
                else
                {
                    Console.WriteLine("Tutulan Balıklar");
                    double turgram = 0;
                    for (int i = 1; i <=adet; i++)
                    {
                        double gram = 0;
                        int olasılık = rnd.Next(100);
                        if (olasılık<75)
                        {
                            gram = rnd.Next(150, 400);
                        }
                        else if (olasılık<95)
                        {
                            gram = rnd.Next(400, 1200);
                        }
                        else
                        {
                            gram = rnd.Next(1200, 2000);
                        }

                        turgram= turgram + gram;
                        toplamkg = toplamkg + gram;
                        Console.WriteLine(i + ". Balık Ağırlığı..: " + gram + " gr");
                    }
                    Console.WriteLine("Bu Turda Tutulan Balıkların Toplam Ağırlığı..:" + turgram);
                }
                baliksay = baliksay + adet; 
                sayac = sayac + 1;
               
                Console.WriteLine("Şimdiye Kadar Tutulan Balıkların Toplam Ağırlığı..: " + toplamkg + " gr\n");
                Thread.Sleep(750);
            }
            int toplamsure = 15 * (sayac - 1);
            Console.WriteLine("Avlanma Tamamlandı. Toplam Süre: "+toplamsure/60 + " Saat "+toplamsure%60+" Dakika");
            Console.WriteLine("Toplam Tutulan Balık Sayısı:{0}\tTutulan Balıkların Toplam Ağırlığı {1} kg", baliksay, (toplamkg / 1000).ToString("N"));
            Console.ReadKey();

        }
    }
}
