using System;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            Console.WriteLine("Current Date and Time: " + DateTime.Now);

            // Ask the user for a number
            Console.WriteLine("Please enter a number of hours:");

            // Read the user's input and convert it to an integer
            int hours = int.Parse(Console.ReadLine());

            // Calculate the future date and time by adding the entered hours to the current date and time
            DateTime futureTime = DateTime.Now.AddHours(hours);

            // Print the future date and time to the console
            Console.WriteLine("\nThe exact time in " + hours + " hours will be: " + futureTime);
            Console.WriteLine("\nPress any key to exit the console");
            Console.ReadLine();
        }
    }
}
