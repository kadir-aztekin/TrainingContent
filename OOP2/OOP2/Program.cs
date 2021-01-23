 using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //KADİR AZTEKİN
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adı = "KADİR";
            musteri1.Soyadı = "AZTEKİN";
            musteri1.Tcno = "12345678910";
            musteri1.Id = 1;


            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SırketAdı = "kodlama.io";
            musteri2.VergiNo = "123456789";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri4);


            //!! musteri classı  hem gercekmusterı hemde tuzelmusterı referansını tutuyot


            //Gerçek(BEN SEN)-- Tuzel(ŞİRKETLER)

        }
    }
}
