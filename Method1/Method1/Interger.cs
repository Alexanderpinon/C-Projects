using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Interger
    {
        
        
        public int Mathoperation(int a)
        {
            int result = a + 2;
            return result;
        }
        public int Mathoperation(decimal a)
        {
            decimal result = a - 1.3m;
            int outcome = Convert.ToInt32(result);
            return outcome;
        }
        public int Mathoperation(string a)
        {
            int outcome = Convert.ToInt32(a);
            outcome = outcome - 4;
            return outcome;
        }

       
    
    }
}
