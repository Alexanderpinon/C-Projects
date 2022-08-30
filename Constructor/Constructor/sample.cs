using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class sample
    {
        public class VariantDate
        {
            public int day;
            public int month;
            public int year;

            public VariantDate(int day) : this(day, 1) { }

            public VariantDate(int day, int month) : this(day, month, 1900) { }

            public VariantDate(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }

        }
    }
}
