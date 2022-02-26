using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List<IloggerService> loggerServices) //interface sayesinde her türlü krediyi alabilir.
        {
            //başvuran bilgilerini değerlendirme

            krediManager.Hesapla();

            //hangi krediyse onun hesapla metodu çalışır.
            //yani bu metot kredi bağımsız oldu.Kim gelirse ona göre bir tavır alır.

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log(); //hangi tipte loglayıcı gönderilmişse ona uygun log() işlemi yapar
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            //bu metot IkrediManager interfaceni implemente eden tüm kredi classlarının listelerini alabilir.
            //listedeki her bir eleman farklı bir kredi çeşidi de olabilir

            foreach (var kredi in krediler)
            {
                kredi.Hesapla(); //listedeki her eleman kendi hesapla fonksiyonuna göre çalışmış olur..
            }


        }



    }
}
