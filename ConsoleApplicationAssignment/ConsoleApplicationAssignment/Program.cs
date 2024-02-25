using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Multiplication - Takes an input from the user, multiplies it by 50, then prints the result to the console         
            //Console.WriteLine("Please enter a number of your choosing: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int num1 = 50;
            //int total = num * num1;
            //Console.WriteLine("The number you choose times 50 is: " + total);
            //Console.ReadLine();

            //Addition - Takes an input from the user, adds 25 to it, then prints the result to the console
            //Console.WriteLine("Please enter a number of your choosing: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int num1 = 25;
            //int total = num + num1;
            //Console.WriteLine("The number you choose plus 25 is " + total);
            //Console.ReadLine();

            //Division - Takes an input from the user, divides it by 12.5, then prints the result to the console
            //Console.WriteLine("Please enter a number of your choosing: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //float num1 = 12.5f;
            //float quotient = (float)num / num1;
            //Console.WriteLine("The number you choose divided by 12.5 is " + quotient);
            //Console.ReadLine();

            //Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console
            //Console.WriteLine("Please enter a number of your choosing: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int num1 = 50;
            //bool greaterThan = num1 < num;
            //Console.WriteLine("The number you choose is greater than 50: " + greaterThan);
            //Console.ReadLine();

            //Takes an input from the user, divides it by 7, then prints the remainder to the console
            Console.WriteLine("Please enter a number of your choosing: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = 7;
            int remainder = num % num1;
            Console.WriteLine("The number you choose divided by 7 has a remainder of: " + remainder);
            Console.ReadLine();

        }
    }
}
