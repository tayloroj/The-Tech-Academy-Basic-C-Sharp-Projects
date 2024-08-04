using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        //Property to store the first name
        public string FirstName { get; set; }
        //Property to store the second name
        public string LastName { get; set; }

        //Method to write the full name to the console
        public void SayName()
        { 
            //Print the full name to the console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
