using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticStatement
{
    internal class Student
    {
        public static int studentNumber { get; set; }

        public static int showStudentNumber()
        {

            return studentNumber;
        }

    }
}
