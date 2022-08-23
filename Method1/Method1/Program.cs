using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Program
    {
        static void Main(string[] args)
        {
            Interger x = new Interger();
            int a;

            Console.WriteLine("Input Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            int result = x.Mathoperation(a);
            Console.Write(result);
            Console.ReadLine();

            result = x.subtraction(a);
            Console.Write(result);
            Console.ReadLine();

            result = x.division(a);
            Console.Write(result);
            Console.ReadLine();
        }
        
    }
}
