using System;
using System.Collections.Generic;

class Program
{
     static void Main()
     {
        //List Fundamentals
        //List using Int
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);
        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //List using strings
        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Johnny");
        intList.Remove("Johnny");
        Console.WriteLine(intList[0]);
        Console.ReadLine();


        //Array Fundamentals
        //Initialize an Array and create a new instance (long way)
        //int[] numarray = new int[5];
        //numarray[0] = 5;
        //numarray[1] = 2;
        //numarray[2] = 10;
        //numarray[3] = 200;
        //numarray[4] = 5000;

        //Initialize an Array and create a new instance (short way)
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //Initialize an Array and create a new instance (even shorter way)
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //Target an array to change a value
        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

    }
}

