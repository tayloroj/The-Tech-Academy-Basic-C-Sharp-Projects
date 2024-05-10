using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to enter a number they want to do the math operations on
            //Call each method in turn, passing the user input to the method. Display the returned integer to the screen
            Console.WriteLine("Enter the amount of your monthly vehicle payment in whole numbers to find our how much interest you pay each month: ");
            int vehiclePymt = Convert.ToInt32(Console.ReadLine());
            int vehicleTax = TaxMethods.Vehicle(vehiclePymt);
            Console.WriteLine("You have paid $" + vehicleTax + " in tax this month.");
        
            Console.WriteLine("\nEnter the amount of your monthly house payment in whole numbers to find our how much interest you pay each month: ");
            int housePymt = Convert.ToInt32(Console.ReadLine());
            int propertyTax = TaxMethods.House(housePymt);
            Console.WriteLine("You have paid $" + propertyTax + " in tax this month.");

            Console.WriteLine("\nEnter the amount of your monthly loan payment in whole numbers to find our how much interest you pay each month: ");
            int loanPymt = Convert.ToInt32(Console.ReadLine());
            int Tax = TaxMethods.Loan(loanPymt);
            Console.WriteLine("You have paid $" + Tax + " in tax this month.");

            Console.WriteLine("\nThe total amount of taxes you have paid this month is: $" + (vehicleTax + propertyTax + Tax));
            Console.ReadLine();
        }

    }
}
