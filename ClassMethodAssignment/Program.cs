using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();
            
            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //Call the DivideByTwo method on the user input
            mathOps.DivideByTwo(userInput);

            //Demonstrate output parameter method
            int resultSum, resultProduct;
            mathOps.CalculateSumAndProduct(5, 3, out resultSum, out resultProduct);
            Console.WriteLine($"Sum: {resultSum}, Product: {resultProduct}");

            //Demonstrate overloaded method with double inputs
            double resultSumDouble, resultProductDouble;
            mathOps.CalculateSumAndProduct(2.5, 3.5, out resultSumDouble, out resultProductDouble);
            Console.WriteLine($"Sum (double): {resultSumDouble}, Product (double): {resultProductDouble}");

            Console.ReadKey();
        }
    }
}
