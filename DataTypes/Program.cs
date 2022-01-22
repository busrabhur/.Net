using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BYTE DATATYPE
            byte var1 = 1;
            byte maxByte=byte.MaxValue;
            byte minByte = byte.MinValue;

            Console.WriteLine("byte");
            Console.WriteLine(var1);
            Console.WriteLine(maxByte); 
            Console.WriteLine(minByte);

            //SHORT DATATYPE
            short var2 = -90;
            short maxShort = short.MaxValue;
            short minShort = short.MinValue;

            Console.WriteLine();
            Console.WriteLine("short");
            Console.WriteLine(var2);
            Console.WriteLine(maxShort);
            Console.WriteLine(minShort);


            //INT DATATYPE
            int var3 = -90000;
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            Console.WriteLine();
            Console.WriteLine("int");
            Console.WriteLine(var3);
            Console.WriteLine(maxInt);
            Console.WriteLine(minInt);


            //LONG DATATYPE
            long var4 = -9878656575879799;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine();
            Console.WriteLine("long");
            Console.WriteLine(var4);
            Console.WriteLine(maxLong);
            Console.WriteLine(minLong);


            //FLOAT
            //7 basamağa kadar
            //ondalıklı bir sayının veritipi ilk olarak double olarak algılanır.Bunu float değişkene atamak için sayının yanında "F" yazılır.floata çevrilir

            float varOndalik = 66.8f; 
            Console.WriteLine();
            Console.WriteLine("float");
            Console.WriteLine(varOndalik);

            //DOUBLE
            //15 basamağa kadar
            double ondalikliSayi = 999.87676;
            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            Console.WriteLine();
            Console.WriteLine("double");
            Console.WriteLine(ondalikliSayi);
            Console.WriteLine(maxDouble);
            Console.WriteLine(minDouble);

            //CHAR
            //tek tırnak ('') arasında tutulur //çift tırnak koyarsan hata alırsın
            //tek bir karakter tutar
            
            char character1 = 'a';
            Console.WriteLine();
            Console.WriteLine("char");
            Console.WriteLine(character1);

            //STRING
            //metin tutar
            //çift tırnak kullanılmalı ("")
            String kelime = "merhaba dünya";
            Console.WriteLine();
            Console.WriteLine("string");
            Console.WriteLine(kelime);


            //BOOL (boolean)
            // true/false haricinde değer tutamaz
            bool control = true;
            bool control2 = false;

            bool control3 = 6 < 4; //false 
            bool sonuc = 5 == 5; //true

            Console.WriteLine();
            Console.WriteLine("bool");
            Console.WriteLine(control);
            Console.WriteLine(control2);
            Console.WriteLine(control3);
            Console.WriteLine(sonuc);

            //OBJECT DataType
            //veritiplerinin atasıdır.
            //tüm veritiplerindeki değerleri içinde tutabilen en kapsamlı veritipi

            object x = "araba";
            object y = 1;
            object z = true;
            z = false;


            Console.WriteLine();
            Console.WriteLine("Object");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //CONSTANT keywordu
            //const keywordu eklenmişsse o değişkenin değeri güncellenmez.
            const double piSayisi = 3.14;
            //piSayisi = 99; ERROR VERİR VE DEĞİŞTİRMEMİZE İZİN VERMEZ









            Console.ReadLine();





        }
    }
}
