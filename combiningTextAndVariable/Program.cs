using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combineText_Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //combining
            String firstName = "Ceren";
            String lastName = "Murdar";
            String fullName=firstName + " " +lastName;

            Console.WriteLine(fullName);

            //for numeric variables, + opr works as a math operator.
            int x = 10;
            int y = 20;
            Console.WriteLine(x + y);


            Console.ReadLine(); //bu olmazsa console ekranı hemen kapanıyor.Bu aslında kullanıcıdan değer almayı sağlae
        }
    }
}
