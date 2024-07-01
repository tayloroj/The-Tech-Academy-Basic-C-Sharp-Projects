using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    // Define the Employee class with a generic type parameter T
    public class Employee<T>
    {
        // Property to store a list of items of type T
        public List<T> Things { get; set; }

        // Constructor to initialize the Things property
        public Employee()
        {
            Things = new List<T>();
        }
    }
}
