﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bakiye = 1000;
            
            string islem = "1-Bakiye görüntüleme \n2-Para Çekme\n3-Para Yatırma\nÇıkış:q";
            Console.WriteLine("*****************İŞLEMLER*****************\n"+islem+ "\n******************************************");
            




            while (true) //sonsuz döngü ,kullanıcı çıkış yapana kadar işlem seçmeye devam edebilecek.
            {
                Console.Write("Lütfen yapmak istediğiniz işlemi seçin:");
                String secim = Console.ReadLine();



                if (secim == "1")
                {
                    Console.WriteLine("Bakiyeniz:" + bakiye);
                }
                else if (secim == "2")
                {
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
                }
                else if (secim == "3")
                {
                    Console.WriteLine("Yatırmak istediğiniz miktar:");
                    double yatirilacak = Convert.ToDouble(Console.ReadLine());
                    bakiye += yatirilacak;
                    Console.WriteLine("güncel bakiye:" + bakiye);
                }
                else if (secim == "q")
                {
                    Console.WriteLine("çıkış yapılıyor...");
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                }
            }




            Console.ReadLine();
        }
    }
}
