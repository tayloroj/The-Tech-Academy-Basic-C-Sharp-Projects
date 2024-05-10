using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class TaxMethods
    {
        //Three methods that take one integer parameter and return an integer
        public static int Vehicle(int vehiclePymt)
        {
            double vehicleTax = vehiclePymt * .05;
            return (int)vehicleTax;
        }

        public static int House(int housePymt)
        {
            double propertyTax = housePymt * .08;
            return (int)propertyTax;
        }

        public static int Loan(int loanPymt)
        {
            double Tax = loanPymt * .18;
            return (int)Tax;
        }        
    }
}
