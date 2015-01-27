using System;

namespace CsharpSolutions.Exercises.Task03
{
    class CurrencyConverter
    {
        //static method to call it like CurrencyConverter.Interaction()
        public static void Interaction()
        {
            //Infinite loop (until user does not want to continue or makes a mistake)
            while (true)
            {
                //Some output
                Console.WriteLine("Enter the amount of money to convert:");
                double amount;

                //Try to convert the input and if so - continue
                if (!double.TryParse(Console.ReadLine(), out amount))
                {
                    //Otherwise output an error and break the loop
                    Console.WriteLine("An error occured. The amount of money has to be a number.");
                    break;
                }

                Console.WriteLine("Enter the currency exchange rate:");
                double rate;

                //Try to convert the input and if so - continue
                if (!double.TryParse(Console.ReadLine(), out rate))
                {
                    //Otherwise output an error and break the loop
                    Console.WriteLine("An error occured. The exchange rate has to be a number.");
                    break;
                }

                //Display converted result
                Console.WriteLine("The converted amount of money is:");
                double converted = amount * rate;
                Console.WriteLine(converted);
                //Ask user if he wants to continue
                Console.WriteLine("Convert another ? (y/n)");
                string input = Console.ReadLine();

                //if not then break
                if (input != "y" && input != "Y")
                    break;
            }
        }
    }
}
