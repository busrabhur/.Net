using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Teacher:Employee
    {
        public String branch { get; set; }
        public void FindSalary()
        {
            Salary = 2000;
        }
        public void SetValues2()
        {
            Position = "Teacher";
            branch = "Math";
        }
    }
}
