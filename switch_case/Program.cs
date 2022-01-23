using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bakiye = 1000;

            string islem = "1-Bakiye görüntüleme \n2-Para Çekme\n3-Para Yatırma\nÇıkış:q";
            Console.WriteLine("*****************İŞLEMLER*****************\n" + islem + "\n******************************************");

            bool control = true;
            while (control)  //sonsuz döngü
            {
                Console.Write("Lütfen yapmak istediğiniz işlemi seçin:");
                String secim = Console.ReadLine();



                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Bakiyeniz:" + bakiye);
                        break; //her case in sonuna konulmalı.

                    case "2":
                        Console.WriteLine("Çekmek istediğiniz miktar:");
                        double cekilecek = Convert.ToDouble(Console.ReadLine());
                        if (cekilecek > bakiye)
                        {
                            Console.WriteLine("yetersiz bakiye!");
                        }
                        else
                        {
                            bakiye -= cekilecek;
                            Console.WriteLine("güncel bakiye:" + bakiye);
                        }
                        break;

                    case "3":
                        Console.WriteLine("Yatırmak istediğiniz miktar:");
                        double yatirilacak = Convert.ToDouble(Console.ReadLine());
                        bakiye += yatirilacak;
                        Console.WriteLine("güncel bakiye:" + bakiye);
                        break;
                    case "q":
                        Console.WriteLine("çıkış yapılıyor..");
                        control = false; //while döngüsünü kırması için
                        break;
                        

                    default: //else görevinde
                        Console.WriteLine("Lütfen geçerli bir işlem giriniz.");
                        break;

                }
            }
        }
    }
}
