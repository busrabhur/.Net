using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class DataBaseLoggerService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("DB'ye loglandı.");
        }
    }
}
