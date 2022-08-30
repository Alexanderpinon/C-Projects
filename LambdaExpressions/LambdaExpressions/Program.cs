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
            Employee employee = new Employee();

            List<Employee> newList = new List<Employee>();
            employee.FirstName = "Alex";
            employee.LastName = "Pinon";
            employee.EmployeeId = 222;
            newList.Add(employee);

            employee.FirstName = "Ann";
            employee.LastName = "Lewis";
            employee.EmployeeId = 2209;
            newList.Add(employee);

            employee.FirstName = "Melissa";
            employee.LastName = "Shepard";
            employee.EmployeeId = 232;
            newList.Add(employee);

            employee.FirstName = "Misty";
            employee.LastName = "Iverson";
            employee.EmployeeId = 09;
            newList.Add(employee);

            employee.FirstName = "Hailey";
            employee.LastName = "Pinon";
            employee.EmployeeId = 3;
            newList.Add(employee);

            employee.FirstName = "joe";
            employee.LastName = "Blare";
            employee.EmployeeId = 1;
            newList.Add(employee);

            employee.FirstName = "Christina";
            employee.LastName = "Lewis";
            employee.EmployeeId = 4;
            newList.Add(employee);

            employee.FirstName = "Leonard";
            employee.LastName = "Lewis";
            employee.EmployeeId = 555;
            newList.Add(employee);

            employee.FirstName = "joe";
            employee.LastName = "Cruz";
            employee.EmployeeId = 22;
            newList.Add(employee);

            employee.FirstName = "joe";
            employee.LastName = "Shepard";
            employee.EmployeeId = 333;
            newList.Add(employee);




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
