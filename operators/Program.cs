using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TOPLAMA ÇIKARMA
            int sayi1 = 3;
            int sayi2 = 4;
            int toplam = sayi1 + sayi2;
            int fark = sayi1 - sayi2;
            Console.WriteLine("toplam:" + toplam);
            Console.WriteLine("fark"+ fark);

            //ÇARPMA-BÖLME
            int carpma = sayi1 * sayi2;
            int bolme = sayi2 / sayi1; // yuvarlama bir sonuç verecek. sonucu int e atadığımız için
            Console.WriteLine("çarpım:" + carpma);
            Console.WriteLine("bölüm" + bolme );

            //MOD ALMA
            int kalan = sayi2 % sayi1;
            Console.WriteLine("bölmedeki kalan:" +kalan);


            //ARTIRMA-AZALTMA
            sayi1++;
            Console.WriteLine("sayi1'in güncel değeri:" +sayi1);
            sayi2--;
            Console.WriteLine("sayi2'nin güncel değeri:" +sayi2);

            //EŞİT Mİ  (==)
            bool control = sayi1 == sayi2;
            Console.WriteLine(control);

            //EŞİT DEĞİL Mİ (!=)
            bool controlEt = sayi1 != sayi2;
            Console.WriteLine(controlEt); //eşit değil yani true

            bool controlEt2 = sayi1 != 4;
            Console.WriteLine(controlEt2); //eşittir yani false

            //KÜÇÜK mü BÜYÜK mü
            int yas = 18;
            bool yasKontrol = yas > 18;
            Console.WriteLine("yaşı 18 den büyük mü ?" +yasKontrol);


            // && (VE) : verilen tüm koşullar doğru ise TRUE ,biri bile yanlışsa FALSE döner.
            int x = 10;
            int y = 20;
            int z = 30;

            bool controlA = x < y && z > y;
            bool controlB = x > y && z > y;

            Console.WriteLine("controlA:" +controlA);
            Console.WriteLine("controlB:" +controlB);

            // || (veya) verilen koşullardan EN AZ BİRİ DOĞRUYSA true döner.

            bool controlC = x == y || z > y;
            Console.WriteLine("controlC:" +controlC);
            bool controlD = x == y || z== y;
            Console.WriteLine("controlD:" + controlD);


            //!(not-değil)
            bool a = true;
            bool b = !(a);
            Console.WriteLine(b);
            Console.WriteLine(!a);

            //Atama operatörleri
            int num1 = 120;
            num1 *= 2;
            Console.WriteLine("num1:"+num1);

            int num2 = 5;
            num2 += 4;
            Console.WriteLine("num2:" +num2);











            Console.ReadLine();


        }
    }
}
