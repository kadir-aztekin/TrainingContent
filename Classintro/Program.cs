using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "Engin";
            int yas = 18;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "c#";
            kurs1.Egitmeni = "Engin Demirog";
            kurs1.İzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "JAVA";
            kurs2.Egitmeni = "KEREM BABA";
            kurs2.İzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "PYTHON";
            kurs3.Egitmeni = "BERKAY BABA";
            kurs3.İzlenmeOranı = 80;

            //Console.WriteLine(kurs1.KursAdı + " " + kurs1.Egitmeni);
            //Console.WriteLine(kurs2.KursAdı + " " + kurs2.Egitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var x in kurslar)
            {
                Console.WriteLine(x.İzlenmeOranı+":l"+x.KursAdı);

            }


        }
    }

    class Kurs
    {
        public string  KursAdı { get; set; }
        public string Egitmeni { get; set; }
        public int İzlenmeOranı { get; set; }

    }
}
