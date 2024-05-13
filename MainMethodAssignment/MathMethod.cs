using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class MathMethod
    {
        //First method that takes an integer
        public int MathOp(int number)
        { 
            return number + 22; 
        }
        //Second method that takes a decimal
        public int MathOp(decimal number) 
        {
            //Convert the decimal to an int to perform the math operation
            int newNum = Convert.ToInt32(number);
            return newNum * 15;
        }
        //Third MathOp method that takes a string
        public int MathOp(string number) 
        {
            //Convert the string to an int to perform the math operation
            int newNum = Convert.ToInt32(number);
            return newNum % 6;
        }
    }
}
