using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Nasuh";
            musteri1.Soyad = "GÜLER";
            musteri1.TelNo = "05444444444";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "DEMİROĞ";
            musteri2.TelNo = "05443333333";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(2, "Engin", "DEMİROĞ", "05443333333");
            musteriManager.Listele(musteriler);

        }
    }
}
