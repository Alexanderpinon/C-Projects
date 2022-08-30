using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> newList = new List<Employee>();
            newList.Add(new Employee { FirstName = "Alex", LastName = "Pinon", EmployeeId = 333 });
            newList.Add(new Employee { FirstName = "Maya", LastName = "Shepard", EmployeeId = 303 });
            newList.Add(new Employee { FirstName = "joe", LastName = "Cruz", EmployeeId = 9 });
            newList.Add(new Employee { FirstName = "Leonard", LastName = "Lewis", EmployeeId = 88 });
            newList.Add(new Employee { FirstName = "Ann", LastName = "Lewis", EmployeeId = 0 });
            newList.Add(new Employee { FirstName = "joe", LastName = "Blarie", EmployeeId = 3 });
            newList.Add(new Employee { FirstName = "Hailey", LastName = "Pinon", EmployeeId = 89 });
            newList.Add(new Employee { FirstName = "Alex", LastName = "Mendoza", EmployeeId = 3338 });
            newList.Add(new Employee { FirstName = "Christina", LastName = "Lewis", EmployeeId = 333 });
            newList.Add(new Employee { FirstName = "Misty", LastName = "Lewis", EmployeeId = 333 });
            
            List<Employee> justJoe = new List<Employee>();
            
            foreach (Employee emp in newList) 
            {
                if (emp.FirstName == "joe")
                {
                    justJoe.Add(emp);
                }
            }
            foreach (Employee emp in justJoe)
            {
                Console.WriteLine("{0} {1} {2}", emp.FirstName, emp.LastName, emp.EmployeeId );
            }

            List<Employee> JustjoeLambda = newList.Where(x => x.FirstName == "joe").ToList();
            foreach (Employee emp in JustjoeLambda)
            {
                Console.WriteLine("{0} {1} {2}", emp.FirstName, emp.LastName, emp.EmployeeId);
            }

            List<Employee> Employeeids = newList.Where(x => x.EmployeeId > 5).ToList();
            foreach (Employee emp in Employeeids)
            {
                Console.WriteLine("{0} {1} {2}", emp.FirstName, emp.LastName, emp.EmployeeId);
            }
            Console.ReadLine();
        }
    }
}
