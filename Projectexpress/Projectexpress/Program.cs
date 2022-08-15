using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectexpress
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Package Express. Please follow the instuctions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            int packWeight = Convert.ToInt32(Console.ReadLine());

           

            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            }
            else
            {
                    Console.WriteLine("Please enter package Width:");
                    int packWidth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter package Height:");
                    int packHeight = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter package Length:");
                    int packLength = Convert.ToInt32(Console.ReadLine());

                if (packWidth + packHeight + packLength > 50)

                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {

                    int products = packWidth * packHeight * packLength * packWeight / 100;
                    Console.WriteLine("Your Quote is " + "$" + products +  " Thank You Have a good day");
                }
            }
            Console.ReadLine();
            
            
            {

            }
        }
    }
}
