using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "YAZILIM GELİSTİCİ YETİSTİRİCİ KAMPI", "PROGRAMLAMAYA BASLANGIC KURSU", "JAVA"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            foreach (string x in kurslar)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("SAYFA SONU ");
        }
    }
}
