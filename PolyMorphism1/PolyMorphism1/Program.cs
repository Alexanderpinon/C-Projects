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
            IQuittable Employee = new Employee();
            Employee.Quit();
            Console.ReadLine();
        }
    }
}
