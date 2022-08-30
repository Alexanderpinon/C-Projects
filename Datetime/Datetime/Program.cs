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
            // here i am putting the time it is now 
            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();

            // here i am asking the user for a number for time in x hours
             Console.WriteLine("Number for time in x hours?");
             int X = Convert.ToInt32(Console.ReadLine());
             DateTime date2 = now.AddHours(X);
             Console.WriteLine("DateTime after operation: {0} ", date2);
             Console.ReadLine();

        }
    }
}
