using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class MathClass
    {
        //Create a void method that takes two integers as parameters
        public void MathOperation(int num1, int num2) 
        {
            //Have the method do a math operation on the first integer
            int result = num1 + 7;

            //Display the second integer to the screen
            Console.WriteLine("The second integer is: " + num2);
            Console.ReadLine();
        }
    }
}
