using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        const int a = 10;
        
        static void Main(string[] args)
        {
            const int b = 20;
            const int c = b + a;
            Console.WriteLine(c);

            var age = 22;
            Console.WriteLine("var holds an int = {0}", age);

            sample sampleOne = new sample();
            Console.WriteLine(sampleOne.month + " " + sampleOne.day + " " + sampleOne.year);
            sample sampleTwo = new sample(30);
            Console.WriteLine(sampleTwo.month + " " + sampleTwo.day + " " + sampleTwo.year);
            Console.ReadLine();
        }
    }
}
