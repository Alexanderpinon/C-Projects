using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intergers = new List<int>() { 1, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("Pick a number to Divide ");
            int number = Convert.ToInt32(Console.ReadLine());
            try
            {
                foreach (int X in intergers)
                {
                    int results = X / number;
                    Console.WriteLine(results);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number. ");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
