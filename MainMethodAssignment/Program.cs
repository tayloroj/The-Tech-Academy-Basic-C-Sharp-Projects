using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the MathMethod class
            MathMethod math1 = new MathMethod();
            //Call the first method with an int parameter
            Console.WriteLine(math1.MathOp(9));
            //Call the second method with a decimal parameter
            Console.WriteLine(math1.MathOp(9.5m));
            //Call the third method with a string parameter
            Console.Write(math1.MathOp("9"));
            Console.ReadLine();
        }
    }
}
