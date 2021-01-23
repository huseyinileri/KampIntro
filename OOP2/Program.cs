using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hüseyin İLERİ Müşteri bilgileri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Hüseyin";
            musteri1.Soyadi = "İLERİ";
            musteri1.TcNo = "55555555555";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama Io";
            musteri2.VergiNo = "123456798";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
