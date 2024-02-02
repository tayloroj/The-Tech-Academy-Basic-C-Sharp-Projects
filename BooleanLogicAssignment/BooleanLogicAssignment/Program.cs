using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application\n");
            
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHave you ever had a DUI? (Yes or No)");
            string answer = Console.ReadLine();
            bool DUI = answer == "yes";  

            Console.WriteLine("\nHow many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nQualified");
            bool qualified = (age > 15) && !DUI && (tickets <= 3); //Checks if answers meet all critieria using boolean AND orerator
            Console.WriteLine(qualified);
        }
    }
}
