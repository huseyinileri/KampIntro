using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategoriler 2021";
            int ogrenciSayisi = 320000000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 8.30;
            double dolarBugun = 8.20;

            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }

            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }

            else
            {
                Console.WriteLine("değişmedi oku");
            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
                
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
