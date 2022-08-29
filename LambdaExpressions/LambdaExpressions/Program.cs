using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            
            List<string> newList = new List<string>() { "Alex", "Billy", "joe", "maya", "Hailey", "leonard", "buddy", "joe", "melissa", "Devin" };

            int counter = 0;
            foreach ("joe" in new List) 
            {
                if (newList == newList."joe")
                {
                    counter++;
                }
            }
            string Name = newList.Where(x => x == "joe").Last();
            Console.WriteLine(Name);

            List<int> EmployeeidList = new List<int>() { 22, 444, 1, 3, 5, 4, 57, 77, 99, 10 };

            int greater = EmployeeidList.Where(x => x > 5).Last();

            Console.WriteLine(greater);
            Console.ReadLine();
        }
    }
}
