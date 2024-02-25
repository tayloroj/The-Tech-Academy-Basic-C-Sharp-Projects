using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 43;
            int num2 = 37;
            int num3 = 68;

            string result = num1 > num2 && num2 < num3 ? "Statement 1" : "Statement 2";
            Console.WriteLine(result);

            //Console.WriteLine("Anonymous Income Comparison Program\n");

            //Console.WriteLine("Person 1");
            //Console.WriteLine("What is your Hourly Rate?");
            //string hourlyRate = Console.ReadLine();
            //Console.WriteLine("How many hours do you work per week?");
            //string weeklyHours = Console.ReadLine();

            //Console.WriteLine("\nPerson 2");
            //Console.WriteLine("What is your Hourly Rate?");
            //string hourlyRate2 = Console.ReadLine();
            //Console.WriteLine("How many hours do you work per week?");
            //string weeklyHours2 = Console.ReadLine();

            //int annualSalary = Convert.ToInt32(hourlyRate) * Convert.ToInt32(weeklyHours) * 52; //Used casting to algin the input given by the user
            //Console.WriteLine("\nAnnual salary of Person 1: " + annualSalary);

            //int annualSalary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(weeklyHours2) * 52; //Used casting to algin the input given by the user
            //Console.WriteLine("\nAnnual salary of Person 2: " + annualSalary2);

            //Console.WriteLine("\nPerson 1 makes more money than Person 2\n");
            //bool moreMoney = annualSalary > annualSalary2; //Takes the input from the users, checks if Person 1 makes more than Person 2, then prints the true/false result to the console
            //Console.WriteLine(moreMoney);
            //Console.ReadLine();
        }
    }
}
