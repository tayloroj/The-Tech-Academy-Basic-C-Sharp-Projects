using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        //Properties for the Employee class
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Overloading the "==" operator
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            //If both are null, or both are the same instancem return true
            if (ReferenceEquals(employee1, employee2)) return true;

            // If one is null, but not both, return false
            if (((object)employee1 == null) || ((object)employee2 == null)) return false;

            //Return true if the fields match
            return employee1.Id == employee2.Id;
        }
        //Overloading the "!=" operator
        public static bool operator !=(Employee employee1, Employee employee2)
        //Return the opposite of the "==" operator
        { return !(employee1 == employee2); }
        //Override Equals method for the "==" operator to function correctly
        public override bool Equals(object obj)
        {
            //Check if the provided object is an Employee
            if (obj is Employee)
            {
                //Cast the object to Employee and compare Ids
                return this.Id == ((Employee)obj).Id;
            }
            //If not an Employee, return false
            return false;
        }
        // Override GetHashCode method
        public override int GetHashCode()
        {
            // Return the Id as the hash code
            return this.Id.GetHashCode();
        }
    }
}
