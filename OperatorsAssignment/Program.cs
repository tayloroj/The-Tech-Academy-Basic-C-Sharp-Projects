using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two Employee objects
            Employee employee1 = new Employee
            {
                Id = 1,
                firstName = "Johnny",
                lastName = "Nonya"
            };
            Employee employee2 = new Employee
            {
                Id = 1,
                firstName = "Grace",
                lastName = "Isgood"
            };
            //Check if the two employees are considered equal
            if (employee1 == employee2)
            {
                Console.WriteLine("Employees are equal.");
            }
            else 
            {
                Console.WriteLine("Employees are not equal.");
            }
            Console.ReadLine();
        }
    }
}
