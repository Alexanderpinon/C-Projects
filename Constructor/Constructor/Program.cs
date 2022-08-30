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
            Console.ReadLine();

            var age = 22;
            Console.WriteLine("var holds an int = {0}", age);

            public class mySampleClass
        {
            public mySampleClass()
            {
                // no parameter constructor method.// First Constructor  
            }
            public mySampleClass(int Age)
            {
                // constructor with one parameter.// Second Constructor  
            }

            public mySampleClass(int Age, string Name)
        }
    }
}
