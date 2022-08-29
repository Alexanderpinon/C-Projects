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
            none,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            string value = "Friday";
            Dayofweek day ;
            Console.WriteLine("Enter current day of week");
            Console.ReadLine();
            Console.WriteLine()
            try
            {
                day = (Dayofweek)Enum.Parse(typeof(Dayofweek), value);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of week");
                Console.WriteLine(ex.Message);
                Console.ReadLine();

                day = Dayofweek.Monday;
            }
            if (day == Dayofweek.Friday)
            {
            }
            
        }
    }
       
}

           
         



        

