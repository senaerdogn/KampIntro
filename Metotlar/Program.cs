using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürünün adı: " + urun.Adi);
                Console.WriteLine("Ürünün fiyatı: " + urun.Fiyati + " TL");
                Console.WriteLine("Ürünün açıklaması: " + urun.Aciklama);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("***************Metotlar***************");
            
            //instance -- örnek
            //Encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);

            Console.ReadLine();
        }
    }
}
