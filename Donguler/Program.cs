using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yetiştirme Kursu Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java Kursu";
            string kurs4 = "Python";
            string kurs5 = "c#";


            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);





            string[] kurslar = new string[] { "Yetiştirme Kursu Kampı", "Programlamaya Başlangıç için Temel Kurs", "Java Kursu", "Python",
            "Hüseyin İleri"};


            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
