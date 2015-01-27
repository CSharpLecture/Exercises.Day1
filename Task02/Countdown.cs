using System;
using System.Threading;

namespace CsharpSolutions.Exercises.Task02
{
    class Countdown
    {
        //static method for calling it like Countdown.Run()
        public static void Run()
        {
            //The for loop going 10, 9, ..., 1
            for (int i = 10; i > 0; i--)
            {
                //Output the time that is left
                Console.WriteLine("Still {0} seconds left ...", i);
                //Wait a second before starting the next iteration
                Thread.Sleep(1000);
            }
        }
    }
}
