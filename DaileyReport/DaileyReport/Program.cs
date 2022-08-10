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
            Console.ReadLine();
            Console.Out.NewLine = "\r\n\r\n";
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.Read();

            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();
            Console.WriteLine("Awesome you are on " + Course + "!");
            Console.Read();

            var pageNumber = 10;
            Console.WriteLine("What page number?");
            Console.Read();
            Console.WriteLine(pageNumber.ToString());
            Console.Read();

            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine("Do you need help with anything,please answer true or false.");
            Console.ReadLine();
            Console.Read();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            Console.ReadLine();
            Console.Read();

            Console.WriteLine("Is there any other feedback you'd like to provide?Please be specific.");
            Console.ReadLine();
            Console.Read();

            var isHours = 8;
            Console.WriteLine("How many hours did you study today?");
            Console.Read();
            Console.WriteLine(isHours.ToString());
            Console.Read();

            Console.WriteLine("Thank you for your answers. an Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
            Console.Read();
        }
    }
}
