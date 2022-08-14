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

            Console.WriteLine("Have you ever had a DUI");
            bool hadDui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have");
            int speedTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");


        }
    }
}
