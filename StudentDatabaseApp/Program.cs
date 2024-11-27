using StudentDatabaseApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new StudentContext())
        {
            // Create a new student
            var student = new Student
            {
                Name = "John Doe",
                Age = 20
            };

            // Add the student to the context
            context.Students.Add(student);

            // Save changes to the database
            context.SaveChanges();

            Console.WriteLine("Student added successfully!");

            // Query the database to verify the student was added
            var addedStudent = context.Students.Find(1);
            if (addedStudent != null)
            {
                Console.WriteLine($"Retrieved student: {addedStudent.Name}, Age: {addedStudent.Age}");
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
