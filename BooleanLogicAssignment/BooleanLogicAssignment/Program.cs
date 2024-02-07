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
            int num1 = 43;
            int num2 = 37;
            int num3 = 68;

            string result = num1 + num2 > num3 ? "Statement 1" : "Statement 2";
            Console.WriteLine(result);

            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 22 ? "Your favorite number is great!" : "That number is garbage!";

            //Console.WriteLine(result);
            //Console.ReadLine();

            //int roomTemp = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temp where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temp.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer that room temp.");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("It is colder than room temp.");
            //}
            //else
            //{
            //    Console.WriteLine("Error, error, wrror....");
            //}

            //Console.ReadLine();           

            //int num1 = 22;
            //int num2 = 25;

            //string result = num1 < num2 ? "num1 is less than num2" : "num1 in not less than num2";
            //Console.WriteLine(result);

            //Console.WriteLine("Car Insurance Application\n");

            //Console.WriteLine("What is your age?");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("\nHave you ever had a DUI? (Yes or No)");
            //string answer = Console.ReadLine();
            //bool DUI = answer == "yes";  

            //Console.WriteLine("\nHow many speeding tickets do you have?");
            //int tickets = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("\nQualified");
            //bool qualified = (age > 15) && !DUI && (tickets <= 3); //Checks if answers meet all critieria using boolean AND orerator
            //Console.WriteLine(qualified);

            //int currentTemp = 80;
            //int roomTemp = 75;

            //string comparisonResult = currentTemp == roomTemp ? "It is room temp" : "It is not room temp"; //Ternary example
            //Console.WriteLine(comparisonResult);

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temp");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("Room temp is warmer than current temp");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temp");
            //}
            //Console.ReadLine();
        }
    }
}
