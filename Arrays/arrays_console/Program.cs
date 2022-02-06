using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] days = new String[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine("Dizinin boyutu: "+days.Length);
            
            //FOR LOOP WITH ARRAYS
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }

            Console.WriteLine("*************************");
            //FOR EACH LOOP WITH ARRAYS
            foreach(String day in days)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("*******2d array***********");

            //2D ARRAYS;
            int[,] array2d = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } , { 7, 8, 9 } };
            for (int i = 0;i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Console.Write(array2d[i,j] +" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("satır sayısı:"+array2d.GetLength(0));
            Console.WriteLine("sutun sayısı:"+array2d.GetLength(1));
            Console.WriteLine("total eleman:"+array2d.Length);



            Console.ReadLine();
        }
    }
}
