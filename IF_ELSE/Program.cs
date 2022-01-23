using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CTRL+K+D : kodu düzenler.
            //EXAMPLE1: finalden 30 altı alanın kaldığı bir karar yapısı

            /*
             * 
            Console.WriteLine("Final notunuzu giriniz:");
            int grade=Convert.ToInt32(Console.ReadLine());
            
            if (grade <= 30)
            {
                Console.WriteLine("Bu dersten başarısız oldunuz.");
            }
            else
            {
                Console.WriteLine("Dersten geçtiniz,tebrikler.");
            }
            */


            //EXAMPLE2:3 not al ortalamasını al ve harf notunu bul
            
            Console.WriteLine("3 sınavdan aldığınız notları sırasıyla giriniz");

            int e1 = Convert.ToInt32(Console.ReadLine());
            int e2 = Convert.ToInt32(Console.ReadLine());
            int e3 = Convert.ToInt32(Console.ReadLine());

            double ortalama = (e1 + e2 + e3) / 3;

            if (ortalama > 80 && ortalama <= 100)
            {
                Console.WriteLine("A+");
            }
            else if (ortalama > 60 && ortalama <= 80)
            {
                Console.WriteLine("A");
            }
            else if (ortalama > 40 && ortalama >= 60)
            {
                Console.WriteLine("B+");
            }
            else
            {
                Console.WriteLine("F");
            }




















            Console.ReadLine();
        }
    }
}
