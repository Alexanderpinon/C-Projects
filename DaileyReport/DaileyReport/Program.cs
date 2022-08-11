using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaileyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy.\nStudent Dailey Report.");
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            

            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();
            Console.WriteLine("Awesome you are on " + Course + "!");
          

            
            Console.WriteLine("What page number?");
           
            int pageNumber = Convert.ToInt32(Console.ReadLine());
          

            
            Console.WriteLine("Do you need help with anything,please answer true or false.");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string Experience = Console.ReadLine();
           

            Console.WriteLine("Is there any other feedback you'd like to provide?Please be specific.");
            string feedback = Console.ReadLine();
           

            
            Console.WriteLine("How many hours did you study today?");

            int studyHours = Convert.ToInt32(Console.ReadLine());   
           

            Console.WriteLine("Thank you for your answers. an Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
            Console.Read();
        }
    }
}
