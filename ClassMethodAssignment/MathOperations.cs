using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public class MathOperations
    {
        //Define a void method named DivideByTwo that takes an integer input and outputs the result of dividing it by 2
        public void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine($"Result of dividing {number} by 2 is: {result}");
        }

        //Define a method with output parameters to calculate the sum and product of two numbers
        public void CalculateSumAndProduct(int num1, int num2, out int sum, out int product)
        {
            sum = num1 + num2;
            product = num1 * num2;
        }

        //Overload the CalculateSumAndProduct method to handle double inputs
        public void CalculateSumAndProduct(double num1, double num2, out double sum, out double product)
        {
            sum = num1 + num2;
            product = num1 * num2;
        }
    }
}
