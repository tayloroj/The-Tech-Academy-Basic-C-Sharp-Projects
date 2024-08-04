using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class MathOperation1
    {
        //Create a method that takes two intergers as parameters
        //Make one parameter optional by providing a default value
        public int MathOperation(int i, int j = 1) 
        {
            //Perform multiplication on integers and rewturn the result
            int result = i * j;
            return result;
        }            
    }
}
