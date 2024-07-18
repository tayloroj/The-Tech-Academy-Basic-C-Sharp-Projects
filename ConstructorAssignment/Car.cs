using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Car
    {
        // Constant variable for maximum speed
        private const int MaxSpeed = 200;

        // Auto-implemented properties for Make and Model
        public string Make { get; private set; }
        public string Model { get; private set; }

        // Constructor that takes both make and model as parameters
        public Car(string make, string model) : this(make) // Chaining to the constructor with one parameter
        {
            // Set the Model property
            this.Model = model;
        }

        // Constructor that takes only make as a parameter
        public Car(string make)
        {
            // Set the Make property
            this.Make = make;
        }

        // Method to display car details
        public void DisplayCarDetails()
        {
            // Using the 'var' keyword to declare a variable
            var carDetails = $"Car Make: {Make}, Car Model: {Model}, Max Speed: {MaxSpeed} km/h";

            // Print the car details to the console
            Console.WriteLine(carDetails);
        }
    }
}
