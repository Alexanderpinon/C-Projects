using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voidmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Interger X = new Interger();

            Console.WriteLine("Input First number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            X.count(num1, num2);
            Console.ReadLine();

            
        }
        
    }
}
