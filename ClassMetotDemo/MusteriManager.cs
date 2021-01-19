using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Ad+"\n");
        }
        public void Sil(int Id,string Ad,string Soyad,string TelNo)
        {
            Console.WriteLine("Müşteri silindi : " + Ad+"\n");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var liste in musteriler)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("ID : " + liste.Id);
                Console.WriteLine("Ad ve Soyad : " + liste.Ad + " " + liste.Soyad);
                Console.WriteLine("TEL NO : " + liste.TelNo);
            }
        }
    }
}
