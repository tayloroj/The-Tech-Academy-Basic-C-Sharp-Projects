using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person
    {
        public int Id { get; set; }
        // Implement the SayName method inside the Employee class
        public override void SayName()
        {
            // Print the full name of the employee
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
