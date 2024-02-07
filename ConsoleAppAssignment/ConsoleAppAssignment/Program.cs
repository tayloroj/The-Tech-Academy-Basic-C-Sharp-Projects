using System;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example While Loop
            int counting = 0;
            while (counting < 3) //Continue to loop until counting reaches 3
            {
                Console.WriteLine("Counting numbers");
                counting++; //Add one to couting each time
            }

            //Example Do While Loop
            int count = 0;
            do
            {
                Console.WriteLine("Inside the loop");
                count++; //Add one to count each time
            }
            while (count < 5); //Continue to loop until counting reaches 5
            Console.ReadLine();
        }
    }
}
