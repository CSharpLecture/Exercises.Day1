using System;
using System.Collections.Generic;

namespace CsharpSolutions.Exercises.Task05
{
    class PrimeNumbers
    {
        //This method can be accessed like PrimeNumbers.Computer()
        public static void Computer()
        {
            //Some output
            Console.WriteLine("Please enter a positive integer number:");
            uint value;

            //Evaluate the given value
            if (!uint.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("The provided input is not a positive integer number.");
                return;
            }

            //Compute the prime factors
            List<uint> factors = ComputeFactorsOf(value);

            if (factors.Count == 1)
            {
                //If there is just one we have a prime number
                Console.WriteLine("This is a prime number!");
            }
            else
            {
                //Otherwise we have no prime number ... print the prime factors
                Console.WriteLine("The value has the prime factors {0}.", string.Join(", ", factors));
            }
        }

        //Create a helper function for computing the various prime factors
        static List<uint> ComputeFactorsOf(uint number)
        {
            //Remember the various factors
            List<uint> factors = new List<uint>();
            uint factor = 2;

            //As long as the number can be divided by something
            while (number > 1)
            {
                //Can it be divided by the factor
                uint rest = number % factor;

                if (rest == 0)
                {
                    number /= factor;
                    factors.Add(factor);
                }
                else
                    factor++;
            }

            return factors;
        }
    }
}
