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
            
            int result = x.Mathoperation(10);
            Console.WriteLine(result);

            
            result = x.Mathoperation(10.3m);
            Console.WriteLine(result);
            

            result = x.Mathoperation("10");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        
    }
}
