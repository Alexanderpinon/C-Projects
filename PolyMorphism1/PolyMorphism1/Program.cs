using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee();
            Employee.firstName = "Sample";
            Employee.lastName = "Student";
            Employee.SayName();
            Console.ReadLine();
        }
    }
}
