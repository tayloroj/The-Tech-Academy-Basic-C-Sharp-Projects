using System;
using System.Collections.Generic;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        //Create a list of integers
        List<int> list = new List<int>() { 32, 7, 1009, 22, 75, 666, 999 };
        //Ask the user for a number to divide each number in the list by.
        bool validNum = false;
        while (!validNum) 
        {
            //Try/catch block to show error message
            try
            {
                Console.WriteLine("Enter a number to divide each number is the list by: ");
                float numberDiv = float.Parse(Console.ReadLine());
                //If statement to check if the user entered 0
                if (numberDiv == 0)
                {
                    Console.WriteLine("Please enter a number other than 0.");
                }
                //Dividing each number in the list by the input
                else 
                {
                    foreach (int num in list)
                    {
                        float Divide = num / numberDiv;
                        Console.WriteLine(num + "/" + numberDiv + " = " + Divide);
                    }
                    validNum = true;
                }
            }
            //Catch block to display the error meeage fro the string input
            catch (FormatException) 
            {
                Console.WriteLine("Wrong, please enter a number.");
            }
        }
        //Message to let the user know the program has exited the try/catch block
        Console.WriteLine("The program has exited the try/catch block");
        Console.ReadLine();
    }
}
