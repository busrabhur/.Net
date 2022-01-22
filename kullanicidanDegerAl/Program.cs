using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanicidanDegerAl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Readline() fonksiyonunu consolu ekranda tutmak için kullanıyordu şimdiye kadar ama asıl amacı input almak
            Console.Write("adınız:");
            string name=Console.ReadLine();
            Console.WriteLine();
            Console.Write("soyadınız:");
            string lastname=Console.ReadLine();

            Console.WriteLine("adınız " +name +"dır" +" soyadınız " +lastname +"dır");

            Console.ReadLine(); //consol ekranı kapanmasın diye ekledik.

        }
    }
}
