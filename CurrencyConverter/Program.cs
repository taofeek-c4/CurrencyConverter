using System;
namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double userInput;
                double dollarExchangeRate = 1599.99;
                double euroExchangeRate = 1746.34;
                double result;

                Console.WriteLine("         CURRENCY CONVERTER");
                Console.WriteLine("\nSelect the option of the Currency you want to convert to Naira:");
                Console.WriteLine("1.   Dollar (USD)");
                Console.WriteLine("2.   Euro (EUR)");

                while (!double.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Invalid input....input a number");
                }
                if (userInput == 1)
                {
                    Console.WriteLine("Enter the Amount of Dollar :");
                    while (!double.TryParse(Console.ReadLine(), out userInput))
                    {
                        Console.WriteLine("Invalid Input....Type a number");
                    }
                    result = userInput * dollarExchangeRate;
                    Console.WriteLine($"\nit is {result} naira ");
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("Enter the Amount of Euro :");
                    while (!double.TryParse(Console.ReadLine(), out userInput))
                    {
                        Console.WriteLine("Invalid Input....input a number");
                    }
                    result = userInput * euroExchangeRate;
                    Console.WriteLine($" \n{result} Naira (NGN) ");
                }
                Console.WriteLine("click \'Y\' to restart and Any other button to end the Application ");
            }
            while (Console.ReadLine()?.ToUpper() == "Y");
        }
    }
}