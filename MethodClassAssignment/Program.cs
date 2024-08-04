using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instatniate the class
            MathClass mathClass = new MathClass();

            //Call the method by passing in two numbers
            mathClass.MathOperation(22, 75);
            //Call the method by specifying the parameters by name
            mathClass.MathOperation(num1: 16,  num2: 25);

        }
    }
}
