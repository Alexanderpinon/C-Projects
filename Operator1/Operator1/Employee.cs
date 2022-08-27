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

        public static Employee operator== (Employee id, Employee id)
        {
            Employee.id.Equal(EmployeeId);
            return Employee;
        }
    }
}
