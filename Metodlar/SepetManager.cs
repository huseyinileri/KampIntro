﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string urunAciklama, double urunFiyati, int stokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urunAdi);
        }
    }
}