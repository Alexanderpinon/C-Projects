using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator1
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeID { get; set; }

        public static bool operator != == (Employee id,  Employee FirstName)
        {
            Employee.id == (EmployeeId);
            return Employee;
        }
    }
}
