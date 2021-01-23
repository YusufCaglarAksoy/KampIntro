using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1234567890;
            musteri1.Adi ="Yusuf Çağlar";
            musteri1.Soyadı="Aksoy";
            musteri1.KrediTipi = "İhtiyaç Kredisi";
            musteri1.KrediBorcu = 10000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1245431440;
            musteri2.Adi = "Mert";
            musteri2.Soyadı = "Kaba";
            musteri2.KrediTipi = "Öğrenci Kredisi";
            musteri2.KrediBorcu = 5000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1181359720;
            musteri3.Adi = "Mehmet Ali";
            musteri3.Soyadı = "Atik";
            musteri3.KrediTipi = "Konut Kredisi";
            musteri3.KrediBorcu = 150000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musterimanager = new MusteriManager();

            musterimanager.Ekle(musteri1);
            musterimanager.Listele(musteriler);
            musterimanager.Silme(musteri2);

        }
    }
}
