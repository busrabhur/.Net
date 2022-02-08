using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Employee:Human  //inheritance
    {
        public string Position { get; set; }
        public double Salary { get; set; }

        public void setValues()
        {
            Name = "Charles";
            Surname = "Dickens";
            ID = 1;
            Gender = 'M';
            age = 30;
        }
    }
}
