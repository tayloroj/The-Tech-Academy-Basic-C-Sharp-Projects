using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        // Define an enum for the days of the week
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            bool isvaild = false;
            while (!isvaild)
            {
                //Try to parse the user input to the DaysOfWeek enum
                try
                {
                    //Prompt the user to enter the current day of the week
                    Console.WriteLine("Please enter the current day of the week: ");
                    string dayinput = Console.ReadLine();
                    //Assign the value to a variable of that enum data type just created
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayinput);
                    //Print the day entered by the user
                    Console.WriteLine("\nHave a nice " + day);
                    Console.ReadLine();
                    isvaild = true;
                }
                catch (ArgumentException ex)
                {
                    // Handle the case when the input is not a valid day of the week
                    Console.WriteLine("Please enter an actual day of the week.");                    
                }                                                
            }
        }
    }
}
