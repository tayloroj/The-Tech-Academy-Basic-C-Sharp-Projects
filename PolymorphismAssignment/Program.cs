using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create an object of type IQuittable
            IQuittable quittableEmployee = new Employee();

            // Call the Quit method using the IQuittable reference
            quittableEmployee.Quit();

            // Pause the console to see the output
            Console.ReadLine();
        }
    }
}
