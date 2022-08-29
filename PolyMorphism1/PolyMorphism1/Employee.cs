using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism1
{
    public class Employee : person, IQuittable
    {
        public void SayName()
        {
            Console.WriteLine("Name " + firstName + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("Employee Quit.")
        }
    }
}
