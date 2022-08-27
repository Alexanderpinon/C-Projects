using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism1
{
    public class person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);
        }
    }
}
