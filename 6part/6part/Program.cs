using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6part
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "jesse", "Erik", "Daniel", "Adam" };
            Console.WriteLine("Input text");
            string userInput = Console.ReadLine();
            for (int j = 0; j < names.Length; j++)
            {
            Console.WriteLine(names[j] + userInput);
            }
            Console.ReadLine();

            int Y = 0;
            int X = 5;
            while(X > 0)
            {

                Console.WriteLine("This is infinite");
                Y = Y + 1;
                if (Y == 5)
                {
                    break;
                }

            }
            Console.ReadLine();

            
            int Z = 4;
            while(Z <= 5)
            {
                Console.WriteLine("this is more than Z");
                Y = Y + 1;
                if (Y == 6)
                {
                    break;
                }
            }
            Console.ReadLine();


            List<string> nam = new List<string>() { "jesse", "Erik", "Danial", "Adam" };

            Console.WriteLine("Enter text:");
            
            bool foundName = false;
            int e = 0;
            int o = 0;
            while (!foundName)
            {

                e = 0;
                string enterText = Console.ReadLine();
                foreach (string name in nam)
                    {
                      

                            if (name == enterText)
                            {

                                Console.WriteLine(e);
                            o = o + 1;
                            }
                            e++;
                            
                        
                    }
                
                if(o == 0)
                {
                    Console.WriteLine("This is not a valid entry");
                    
                }
                else
                {
                    foundName = true;
                }
            }
                Console.ReadLine();

            List<string> identical = new List<string>() { "Hello", "Hello", "I", "am", "program" };
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            int i = 0;

            if (identical.Contains(text))
            {
                foreach (string name in identical)
                {

                    if (name == text)
                    {

                        Console.WriteLine(i);

                    }
                    i++;

                }
            }
            else
            {
                Console.WriteLine("This is not a valid entry");
            }
            Console.ReadLine();


            List<string> unique = new List<string>() { "Hi", "i", "am", "your", "Hi" };
            List<string> special = new List<string>();

            foreach (string name in unique)
            {
                if(special.Contains(name))
                {
                    Console.WriteLine(name + " - this item is duplicate ");
                }
                else
                {
                    Console.WriteLine(name + " - this item is unique");
                }
                special.Add(name);
            }
            Console.ReadLine();

        }
    }
}
