using System;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
            Console.WriteLine("Please enter the weight of the package:");
            decimal weight = Convert.ToDecimal(Console.ReadLine()); //Using decimal so the info entered does not only have to be a round number
            //if-else block to instruct what to do is the package weighes more that 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the width of the package");
                decimal width = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the height of the package");
                decimal height = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the length of the package");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                if ((width + height + length) > 50) //if-else block to instruct what to do if the combined whl is greater than 50
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.\n");
                }
                else
                {
                    //Calcuation of the package using input from user
                    decimal quote = width * height * length * weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is $" + quote.ToString("0.00"));//Quoting to string to get two decimal point output
                    Console.WriteLine("Thank you!");
                }
            }                  
        }
    }
}
