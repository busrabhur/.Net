using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*daha kapsamlı olan tipteki veriyi daha az kapsamlı olan bir veritipine dönüştürürken değer kaybı yaşanabilir
             *örneğin int'ten byte 'a bir dönüştürme yapılırken 500 değerine sahip int değişkeni byte'a çevirirsen
             *byte veritipi mac 255 tutabildiği için 500 değerini tutamaz ve veri kaybı yaşanır. 254 gibi bir rakama çevrilir.
            */


            int a = 500;
            byte b=(byte)a;
            Console.WriteLine("b'nin değeri:"+b);
            Console.WriteLine("b'nin veritipi:"+b.GetType());

            /* IMPLICIT CASTING (automatically) - converting a smaller type to a larger type size
             * char -> int -> long -> float -> double 
             * Implicit casting is done AUTOMATICALLY when passing a smaller size type to a larger size type:
             */



            //int to double (automatically)
            int num1 = 9;
            double num2= num1;

            //int to long (automatically)
            long num3 = num1;



            /* EXPLICIT CASTTING (manually) - converting a larger type to a smaller size type
            *  double -> float -> long -> int -> char
            *  Explicit casting must be done manually by placing the type in parentheses in front of the value:
            */


             //DOUBLE TO INT(Manually)
            double num4 = 9.81;
            int num5 =(int) num4; //double'ı inte çevirdik ama değer kaybı yaşadık sadece tam sayı kısmı atandı
            Console.WriteLine("num4:" +num4);
            Console.WriteLine("num5:" + num5);

            /* It is also possible to convert data types EXPLICITLY by using built-in methods; 
             * Convert.ToBoolean
             * Convert.ToDouble
             * Convert.ToString
             * Convert.ToInt32 (int)
             * Convert.ToInt64 (long): */


            //STRING TO INT
            
            //first way:
            String sayi1 = "1";
            String sayi2 = "2";
            int x=int.Parse(sayi1); //Sayi1 ve Sayi2  string tipinde kalacak.
            int y=int.Parse(sayi2);

            Console.WriteLine(sayi1.GetType());
            Console.WriteLine(x.GetType());

            //second way:

            int x1 = Convert.ToInt32(sayi1);
            int y1=Convert.ToInt32(sayi2);

            Console.WriteLine(x1.GetType());
            Console.WriteLine(y1.GetType());

            //INT TO STRING
            int k = 111;
            string metin=Convert.ToString(k);
            Console.WriteLine(metin.GetType());
            Console.WriteLine(k.GetType());

            //TO STRING  
            int z = 1;
            String n=z.ToString();

            //DOUBLE TO INT //değer kaybeder.
            double number = 3.33;
            int number2= Convert.ToInt32(number);
            Object typeNumber2 = number2.GetType();
            String s=typeNumber2.ToString();
            Console.WriteLine(s+" " +number2.ToString());



            //Kullanıcıdan alınan inputlar 'string' tipinde alınır default olarak
            Console.WriteLine("yaşınızı girin:");
            String yas = Console.ReadLine();
            //yaşı 18 den küçükmü değil mi kontrol edelim bunun için sayıya dönüştürmelisin
            int age0=int.Parse(yas); //1.yol
            int age=Convert.ToInt32(yas);//2.yol
            bool control = age >= 18;
            Console.WriteLine(control);

            //kullanıcıdan 2 sayı al toplamını bul
            Console.WriteLine("birinci sayı:");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayı:");
            int secNum = Convert.ToInt32(Console.ReadLine());
            int sum = firstNum + secNum;
            Console.WriteLine("toplam:"+sum);
            Console.WriteLine("toplam:" +(firstNum+secNum)); //!!!! burada matematiksel toplamayı parantez içine almazsan string birleştirme gibi davranıyor ,dikkat et.























            Console.ReadLine();


        }
    }
}
