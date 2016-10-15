using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool b = isRun(2000);
            Console.WriteLine(b);
            Console.ReadKey();


        }
        public static bool isRun(int year)
        {
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            return b;
        }
    }
}
