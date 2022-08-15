using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
           

                Console.WriteLine("Insurance Approval");

                Console.WriteLine("What is your age?");
                int ageNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Have you ever had a DUI, Please say true or false");
                bool hadDui = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("How many speeding tickets do you have");
                int speedTickets = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qualified?");

            if (ageNumber > 15 && hadDui == false && speedTickets <= 3)
            {
                Console.WriteLine("You Qualify");
            }
            else
            {
                Console.WriteLine("You do not Qualify");
            }
            Console.ReadLine();

            }
        }
    }

