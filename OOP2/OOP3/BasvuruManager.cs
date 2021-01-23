using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Basvuran Bilgisi Değerlendirme
            krediManager.Hesapla();
            loggerService.Log();


        }
        public void KrediOnBilgilendırmesıYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }     
        }
       
    }

}
