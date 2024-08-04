using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type string
            Employee<string> employeeString = new Employee<string>();
            // Assign a list of strings to the Things property
            employeeString.Things.AddRange(new List<string> { "Task1", "Task2", "Task3" });

            // Instantiate an Employee object with type int
            Employee<int> employeeInt = new Employee<int>();
            // Assign a list of integers to the Things property
            employeeInt.Things.AddRange(new List<int> { 1, 2, 3 });

            // Loop through the list of strings and print each item
            Console.WriteLine("Employee with string type Things:");
            foreach (var thing in employeeString.Things)
            {
                Console.WriteLine(thing);
            }

            // Loop through the list of integers and print each item
            Console.WriteLine("\nEmployee with int type Things:");
            foreach (var thing in employeeInt.Things)
            {
                Console.WriteLine(thing);
            }

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
