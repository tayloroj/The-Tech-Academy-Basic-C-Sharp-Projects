using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    
    //Define a struct called Number
    public struct Number 
    {
        //Define a property named Amount of type decimal
        public decimal Amount { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of the Number struct
            Number number = new Number();
            
            //Assign a value to the Amount property of the Number instance
            number.Amount = 129.22m;

            //Print the value of the Amount property to the console
            Console.WriteLine("The amount is: " + number.Amount);

            //Pause the console to view the result
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
