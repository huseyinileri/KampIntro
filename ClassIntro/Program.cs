using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Hüseyin";
            int yas = 37;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Hüseyin";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Hasan";
            kurs2.IzlenmeOrani = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "husso";
            kurs3.IzlenmeOrani = 58;

           // Console.WriteLine(kurs1.KursAdi + " :  " + kurs1.Egitmen);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
