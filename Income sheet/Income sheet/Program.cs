using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_sheet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous income Comparison program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("hourly rate");
            int hourRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("hourly rate");
            int hoursRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            int hourWorked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of person 1:");
            int product = hourRate * hoursWorked * 52;
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine("Annual salary of person 2:");
            int products = hoursRate * hourWorked * 52;
            Console.WriteLine(products);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2");
            bool isIncome = product > products;
            Console.WriteLine(isIncome);
            Console.ReadLine();
        }

    }
    }

