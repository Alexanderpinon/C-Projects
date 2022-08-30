using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class sample
    {
            public int day;
            public int month;
            public int year;

            public sample() : this(5, 9, 2000) { }
            public sample(int day) : this(day, 1, 1909) { }

            public sample(int day, int month) : this(day, month, 1900) { }

            public sample(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
    }
}
