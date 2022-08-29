using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysWeek
{
    class Program
    {
        enum Dayofweek
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter current day of week");
            string dayWeek = Console.ReadLine();
            try
            {
                Dayofweek day = (Dayofweek)Enum.Parse(typeof(Dayofweek), dayWeek);
                Console.WriteLine("The day of the week is {0}", day);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of week");
                Console.WriteLine(ex.Message);
            }
             Console.ReadLine();
        }
    }
       
}

           
         



        

