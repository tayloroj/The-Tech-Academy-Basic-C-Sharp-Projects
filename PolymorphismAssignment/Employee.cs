using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Employee : IQuittable
    {
        // Implementation of the Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Employee has quit with no notice.");
        }
    }
}
