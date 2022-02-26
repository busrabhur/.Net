using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager=new IhtiyacKrediManager();
            KonutKrediManager konutKrediManager =new KonutKrediManager();
            TasitKrediManager tasitKrediManager= new TasitKrediManager();
            
            BasvuruManager basvuruManager = new BasvuruManager();

            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //başvuru yapa tüm tipteki kredileri gönderebiliriz kimi gönderirsek onun hesapla metodu çalışır.

            List<IKrediManager> krediler=new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            Console.WriteLine("******************************");
            
            basvuruManager.BasvuruYap(ihtiyacKrediManager ,new List<IloggerService> {new DataBaseLoggerService()
            ,new FileLoggerService()});













            Console.ReadLine();
        }
    }
}
