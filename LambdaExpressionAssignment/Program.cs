using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {// Create a list of employees with at least 10 employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Anna", LastName = "Brown" },
                new Employee { Id = 5, FirstName = "Joe", LastName = "Davis" },
                new Employee { Id = 6, FirstName = "Emily", LastName = "Clark" },
                new Employee { Id = 7, FirstName = "Michael", LastName = "Rodriguez" },
                new Employee { Id = 8, FirstName = "Sarah", LastName = "Lee" },
                new Employee { Id = 9, FirstName = "David", LastName = "King" },
                new Employee { Id = 10, FirstName = "Chris", LastName = "Walker" }
            };

            // Create a new list to store employees with the first name "Joe" using a foreach loop
            List<Employee> office = new List<Employee>();
            foreach (var employee in employees)
            {
                // Check if the first name of the employee is "Joe"
                if (employee.FirstName == "Joe")
                {
                    office.Add(employee);
                }
            }

            // Output the list of employees with the first name "Joe" created using foreach loop
            Console.WriteLine("Employees with the first name 'Joe' using foreach loop:");
            foreach (var joe in office)
            {
                Console.WriteLine($"Id: {joe.Id}, FirstName: {joe.FirstName}, LastName: {joe.LastName}");
            }

            // Create a new list to store employees with the first name "Joe" using a lambda expression
            List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Output the list of employees with the first name "Joe" created using lambda expression
            Console.WriteLine("\nEmployees with the first name 'Joe' using lambda expression:");
            foreach (var joe in joesLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, FirstName: {joe.FirstName}, LastName: {joe.LastName}");
            }

            // Create a new list to store employees with Id greater than 5 using a lambda expression
            List<Employee> idGreaterThanFive = employees.Where(x => x.Id > 5).ToList();

            // Output the list of employees with Id greater than 5
            Console.WriteLine("\nEmployees with Id greater than 5:");
            foreach (var employee in idGreaterThanFive)
            {
                Console.WriteLine($"Id: {employee.Id}, FirstName: {employee.FirstName}, LastName: {employee.LastName}");
            }
            Console.ReadLine();
        }
    }
}
