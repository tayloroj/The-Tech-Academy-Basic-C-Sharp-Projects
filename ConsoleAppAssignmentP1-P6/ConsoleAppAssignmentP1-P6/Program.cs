using System;
using System.Collections.Generic;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        //Part 1
        //Create a one - dimensional Array of strings.
        string[] stringArray = { "Blue ", "Red ", "Green ", "Yellow " };

        //Ask user to input a string and assign string to stringAdd
        Console.WriteLine("Please input the name of a flower to append to the end of each string in the array");
        string stringAdd = Console.ReadLine();

        //Create a loop to iterate through stringArray, concatenating stringArray and stringAdd
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = stringArray[i] + stringAdd;
        }

        //Create a loop to iterate through stringArray and print out stringArray
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine(stringArray[i]);
            //part 2
            //create an infinite loop (change "stringArray[i]" to "i--") for infinite loop.
            //fix the infinite loop.
            // Remove the -- from the [i--]
        }        
        Console.ReadLine();

        //Part 3
        Console.WriteLine("Whaz up?!");
        StringBuilder whaz = new StringBuilder();
        whaz.Append("Wha");
        //Create a loop where the comparision that's used to determine whether to continue iterating the loop is a "<" operator.
        while (whaz.Length < 25) 
        {
            whaz.Append("z");
        }
        whaz.Append(" up!");
        Console.ReadLine();
        Console.WriteLine(whaz);
        Console.ReadLine();
        StringBuilder sky = new StringBuilder();
        sky.Append("The Sk");
        //Add a loop where the comparison that's used to determine whether to continue iterating the loop is a "<=" operator.
        while (sky.Length <= 15)
        {
            sky.Append("y");
        }
        sky.Append("!");
        Console.WriteLine(sky);
        Console.ReadLine();
        //Part 4
        //Create a List of strings where each item in the list is unique.
        List<string> teams = new List<string>()
        { "Jayhawks", "Wildcats", "Bears", "Cougars(BYU)", "Knights", "Bearcats", "Cougars(Houston)", "Cyclones", "Sooners", "Cowboys", "Longhorns", "Horned Frogs", "Red Raiders", "Mountaineers" };
        Console.WriteLine("Big 12 Standings");
        //Ask user to input text to search form in the List.
        Console.WriteLine("Enter team name:");
        int standing = 0;
        bool isValid = false;
        int index = 0;
        //Create a loop that iterates through the lkiust and then displays the index of the array that contains matching tet on the screen.
        while (!isValid) 
        {
            int i2 = 0;
            string teamrequest = Console.ReadLine();
            foreach (string team in teams) 
            {
                if (teamrequest == team) 
                {
                    standing = i2 + 1;
                    index = i2;
                }
                i2++;
            }
            //Add code to that above loop that tells a user if they put in text that isn't in the List.
            if (standing == 0) 
            {
                Console.WriteLine("That is not a valid team name. Enter again:");
            }
            //Add code to that above loop that stops it from executing once a match has been found.
            else
            {
                isValid = true;
            }
        }
        Console.WriteLine("Processing... Index is: " + index + ". So...");
        Console.WriteLine("Standing is: " + standing);
        Console.ReadLine();
        //Part 5
        //Create a List of strings that has at least two identical strings in the List.
        List<string> players = new List<string>() { "Mickey Mantle", "Ty Cobb", "Will Clark", "Ty Cobb", "Will Clark" };
        Console.WriteLine("Welcome to Royals station! \nPlease use the station to selectThe statement you agree with most out of the list. \nBest first baseman is: " + 
            "\"Will Clark\". \nBest Yankee player is: \"Mickey Mantle\". \nBest ball player of all time is: \"Ty Cobb\".");
        //Ask the user to select text to search for in the List.
        Console.WriteLine("Enter selection:");
        string selection = Console.ReadLine();
        while (!(selection == "Mickey Mantle" || selection == "Will Clark" || selection == "Ty Cobb")) 
        {
            //Add code that tells a user if they put in text that isn't in the List.
            Console.WriteLine("Please enter one of the 3 choices:");
            selection = Console.ReadLine();
        }
        Console.WriteLine("The player you selected is:");
        //Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.
        for (int i3 = 0; i3 < players.Count; i3++) 
        {
            if (selection == players[i3]) 
            {
                Console.WriteLine(i3);
            }
        }
        Console.ReadLine();

        //Part 6
        //Create a List of strings that has at least two identical strings in the List.
        List<string> names = new List<string>() { "Johnny", "Ben", "Betty", "Johnny", "Lucy", "Lana", "Lucy" };
        List<string> repeatCheck = new List<string>();
        Console.WriteLine("Class Roster:");
        //Create a foreach loop that evaluates each item in the lsit, and displays a message showing the string and whether or not it has already appeared in the list.
        foreach (string name in names) 
        {
            Console.WriteLine(name);
            if (repeatCheck.Contains(name))
            {
                Console.WriteLine("This name has been repeated. \nUse last name initial when referring to this student.");
            }
            else 
            {
                Console.WriteLine("This name has not been repeated.");
            }
            repeatCheck.Add(name);
        }
        Console.ReadLine();
    }
}
