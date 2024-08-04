using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person
    {
        // Define two properties: firstName and lastName
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Define an abstract method called SayName
        public abstract void SayName();
    }
}
