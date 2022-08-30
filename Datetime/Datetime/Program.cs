using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();

            Console.WriteLine("Number for time in x hours?");
            DateTime dateTimeTime = Convert.ToDateTime(Console.ReadLine());
        }
    }
}
