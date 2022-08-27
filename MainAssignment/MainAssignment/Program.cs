using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            interger X = new interger();
            Console.WriteLine("Input first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number:");
            

            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                X.Mathoperation(num1, num2);
            }
            catch
            {
                X.Mathoperation(num1);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
