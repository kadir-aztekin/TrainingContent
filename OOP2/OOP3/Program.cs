using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();


            ILoggerService databaselogger = new DataBaseLoggerService();
            ILoggerService fileloger = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager(); //BU METHOD HANGI KREDI GONDERILIRSE CALISIR 
            basvuruManager.BasvuruYap(konutKrediManager,databaselogger); ////BU METHOD HANGI KREDI GONDERILIRSE CALISIR 
            basvuruManager.BasvuruYap(ihtiyacKrediManager,fileloger);
            basvuruManager.BasvuruYap(tasıtKrediManager, new SmsLoggerService());
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasıtKrediManager };
            //basvuruManager.KrediOnBilgilendırmesıYap(krediler);





            

        }
    }
}
