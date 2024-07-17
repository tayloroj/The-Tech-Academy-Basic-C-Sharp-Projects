using System;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        // The path to the text file where the number will be logged
        const string filePath = @"C:\Users\tayloroj\logs\numberLog.txt";

        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            // Log the user's input to the text file
            LogNumberToFile(userInput);

            // Read the contents of the text file and print it back to the user
            PrintFileContents();

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        // Method to log the user's input to a text file
        static void LogNumberToFile(string number)
        {
            // Using StreamWriter to write the number to the text file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(number);
            }
        }
        // Method to read the contents of the text file and print it to the console
        static void PrintFileContents()
        {
            // Check if the file exists before attempting to read it
            if (File.Exists(filePath))
            {
                // Using StreamReader to read the contents of the text file
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string fileContents = reader.ReadToEnd();
                    Console.WriteLine("Contents of the file:");
                    Console.WriteLine(fileContents);
                }
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }

        }
    }
}
