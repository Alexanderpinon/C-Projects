using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classsubmission
{
    public class Method
    {
        public void Divide(int x)
        {
            int outcome = x / 2;
            Console.WriteLine(outcome);
        }

        public void divide(out int outcome)
        {
            int x = 10;
            outcome = x / 2;
            Console.WriteLine(outcome);
        }

        public void divide(string x)
        {
            Console.WriteLine(x);
        }
            

        internal void MyMethod(int num1)
        {
            Console.WriteLine(num1);
        }
    }
}
