using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpSolutions.Exercises.Task04
{
    class Calculator
    {
        //This can be called by using Calculator.Compute()
        public static void Compute()
        {
            //Output something
            Console.WriteLine("First operand:");
            double left;

            //Check the input
            if (!double.TryParse(Console.ReadLine(), out left))
            {
                Console.WriteLine("You have entered an invalid number.");
                return;
            }

            //Request second input
            Console.WriteLine("Second operand:");
            double right;

            //Check the input, too
            if (!double.TryParse(Console.ReadLine(), out right))
            {
                Console.WriteLine("You have entered an invalid number.");
                return;
            }

            //And demand the operation - we need to check for ...
            Console.WriteLine("Operation (+,-,*):");
            string op = Console.ReadLine();

            //length of the input being a single character
            if (op.Length == 1)
            {
                switch (op[0])
                {
                        //And being +
                    case '+':
                        Console.WriteLine("The result is {0} + {1} = {2}.", left, right, left + right);
                        return;

                        //or being -
                    case '-':
                        Console.WriteLine("The result is {0} - {1} = {2}.", left, right, left - right);
                        return;

                        //or being *
                    case '*':
                        Console.WriteLine("The result is {0} * {1} = {2}.", left, right, left * right);
                        return;
                }
            }

            //If we reach this, we have an invalid operation
            Console.WriteLine("You have entered an invalid operation.");
        }
    }
}
