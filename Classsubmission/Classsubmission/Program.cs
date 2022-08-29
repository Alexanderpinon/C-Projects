using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classsubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Method X = new Method();
            
            Console.WriteLine("Input First number");

            int outcome = Convert.ToInt32(Console.ReadLine());
            X.MyMethod(outcome);
            Console.ReadLine();

            X.MyMethod(outcome);
            Console.ReadLine();

            string y = StaticMethod.MyMethod();
            Console.WriteLine(y);
            Console.Read();
        }
    }
}
