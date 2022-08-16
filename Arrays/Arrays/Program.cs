using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("i");
            intList.Add("am");
            intList.Add("Alex");

            Console.WriteLine("Please select a number between 0-3");
            int nameList= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intList[nameList]);
            Console.ReadLine();

            string[] newArray = new string[5];
            newArray[0] = "hello";
            newArray[1] = "i";
            newArray[2] = "am";
            newArray[3] = "your";
            newArray[4] = "program";

            Console.WriteLine("Please select a number between 0-4");
            int stringArray = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(newArray[stringArray]);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("does not exist");
            }

            int[] numArray = new int[5];
            numArray[0] = 1;
            numArray[1] = 2;
            numArray[2] = 3;
            numArray[3] = 4;
            numArray[4] = 5;

            Console.WriteLine("Please select a number between 0-5");
            int numberArray = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(numArray[numberArray]);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("does not exist");
            }
            Console.ReadLine();

        }
    }
}
