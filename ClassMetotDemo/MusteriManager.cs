using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+" Adlı "+musteri.Id+" Numaralı Müşteri Eklendi");
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " Adlı " + musteri.Id + " Numaralı Müşteri Silindi");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach(var musteri in musteriler)
            {
                Console.WriteLine("\nMüşteri Numarası: "+musteri.Id+"\nMüşteri Adi: "+musteri.Adi+"\n Müşteri Soyadı: "+musteri.Soyadı+"\nMüşteri Kredi Tipi: "+musteri.KrediTipi+"\nMüşteri Kredi Borcu: "+musteri.KrediBorcu+"\n");
            }
        }

    }
}
