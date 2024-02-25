using System;
using System.Collections.Generic;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a one-dimensional Array of strings
            string[] fruitArray = { "Apple", "Orange", "Banana", "Kiwi", "Strawberry", "Blueberry" };
            //Ask the user to select an index of the Array
            Console.WriteLine("Pick a number between 0 and 5");
            //Display the string at that index on the screen
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while (!validString)
            {
                try
                {
                    Console.WriteLine("The fruit you picked is " + fruitArray[stringSelect]);
                    validString = true;
                }
                //Add in a message that displays when the user selects an index that doesn’t exist
                catch
                {
                    Console.WriteLine("Invaild selecion, Please pick a number between 0 and 5");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Create a one-dimensional Array of integers
            int[] intArray = { 4, 22, 36, 84, 18, 73 };
            //Ask the user to select an index of the Array and then display the integer at that index on the screen.
            Console.WriteLine("\n\nPick a number between 0 and 5");
            //Display the string at that index on the screen
            int intSelect = Convert.ToInt32(Console.ReadLine());
            bool validInt = false;

            while (!validInt)
            {
                try
                {
                    Console.WriteLine("The output for the number you selected is " + intArray[intSelect]);
                    validInt = true;
                }
                //Add in a message that displays when the user selects an index that doesn’t exist
                catch
                {
                    Console.WriteLine("Invaild selecion, Please pick a number between 0 and 5");
                    intSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Create a list of strings
            List<string> gameConsoleList = new List<string>()
            { "Playstation", "X-Box", "Nintendo", "Sega", "Atari", "Polymega"};
            //Ask the user to select an index of the list
            Console.WriteLine("\n\nPick a number between 0 and 5");
            //Display the string at that index on the screen
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList)
            {
                try
                {
                    Console.WriteLine("The console you picked is " + gameConsoleList[listSelect]);
                    validList = true;
                }
                //Add in a message that displays when the user selects an index that doesn’t exist
                catch
                {
                    Console.WriteLine("Invaild selecion, Please pick a number between 0 and 5");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();
        }
    }
}