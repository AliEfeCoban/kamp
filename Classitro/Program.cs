using System;

namespace Classitro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Ali Çoban";
            kurs2.IzlenmeOrani = 58;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "Zeki Kilinc";
            kurs3.IzlenmeOrani = 38;

            //Console.WriteLine(kurs1.KursAdi + ";" + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ";" + kurs.Egitmen);
            }


            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
    }
}
