using System;
using System.Text;

namespace StringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Concatenate three strings
            //string stringOne = "This is ";
            //string stringTwo = "how to concatenate ";
            //string stringThree = "strings";
            //Console.WriteLine(stringOne + stringTwo + stringThree.ToUpper()); //Example of the toUpper use to make all upper case letters
                      
            //Example of how to use StringBuilder
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("This is a paragraph to showcase how to use StringBuilder. ");
            stringBuilder.Append("It is useful tool. ");
            stringBuilder.Append("It's purpose is to reduce storage of strings in the cache slowing down the process. ");
            stringBuilder.Append("I will never work with anything that will be that big.");
            Console.WriteLine(stringBuilder);
            Console.ReadLine();
        }
    }
}
