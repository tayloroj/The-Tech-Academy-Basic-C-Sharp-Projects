using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                // Ask the user for their age
                Console.Write("Please enter your age: ");
                int age = int.Parse(Console.ReadLine());  // Read and parse the user's input as an integer

                // Check if the age is less than or equal to zero
                if (age <= 0)
                {
                    Console.WriteLine("Error: Age cannot be zero or negative.");  // Display an error message for invalid age
                }
                else
                {
                    // Calculate the year the user was born
                    int birthYear = DateTime.Now.Year - age;
                    Console.WriteLine("You were born in the year: " + birthYear);  // Display the calculated birth year
                }
            }
            catch (FormatException)  // Handle exceptions where input is not a number
            {
                Console.WriteLine("Error: Please enter a valid number for your age.");
            }
            catch (Exception ex)  // Handle any other exceptions
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
