using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyList<T> //generic class:ben bu classta T ile çalışacağım
        //Bana bir tip vereceksin ben de aşağıdaki sınıf özelliklerinde ona göre yapılandırma yapacağım demek
    {


        public void Add(T item) //programcı bu classtan nesne tanımlarkem hangi tipi vermişsse onu kullansın 
        {
            //listeler aslında arka planda array yönetir.Bu classtan obje oluşturduğun an yani new lediğin anda
            //bir array oluşabilmesi için Constructor içinde bir array oluşturman lazım

        }
    }
}
