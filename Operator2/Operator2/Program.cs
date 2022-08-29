using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator2
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate employee one and two
            Employee empOne = new Employee() { FirstName = "Alex", LastName = "Pinon", EmployeeID = 222 }; 
            Employee empTwo = new Employee() { FirstName = "Maya", LastName = "Shepard", EmployeeID = 333 };
            // made a if statment to compare them
            if (empOne == empTwo)
            {
                Console.WriteLine("They are equal!");
            }
            else
            {
                Console.WriteLine("They are not equal!");
            }
            if (empOne != empTwo)
            {
                Console.WriteLine("They are not equal!");
            }
            else
            {
                Console.WriteLine("They are equal!");
            }
            Console.ReadLine();
        }
    }
}
