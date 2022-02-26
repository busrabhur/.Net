using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager 
    {
        //Bu interfacei kullanan classlar aşağıda imzası verilen metotları mutlaka bulundurmalı.Yoksa Hata
        //interfacedeki metotların başına access modifier koyma
        //Interface isimleri I harfiyle başlar


        //interface bir şablondur ve bunu kullanan classların bu şablona uymasını ister
        void Hesapla();
        void BirseyYap();

        
    }
}
