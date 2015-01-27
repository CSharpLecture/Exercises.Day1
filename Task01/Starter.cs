using System;

namespace CsharpSolutions.Exercises.Task01
{
    class Starter
    {
        //Static method to call it like Starter.DisplayUser()
        public static void DisplayUser()
        {
            //Write some info on the console
            Console.WriteLine("Please enter your name:");
            //Request the user to input his name, store it in name
            string name = Console.ReadLine();
            //Output the name of the user by using a formatted string
            Console.WriteLine("Your name is {0}. Hi!", name);
        }
    }
}
