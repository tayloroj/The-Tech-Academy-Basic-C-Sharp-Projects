using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Car class using the constructor with two parameters
            Car myCar = new Car("Toyota", "Corolla");

            // Display the car's details
            myCar.DisplayCarDetails();
        }
    }
}
