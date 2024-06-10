using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and initalize an Employee object/Set the first name and set the last name
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Call the SayName method on the EMployee object
            employee.SayName();
            Console.ReadLine();
        }
    }
}
