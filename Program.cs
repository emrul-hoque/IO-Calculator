using System;
using System.IO;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("What is your name? ");
            string? name = Console.ReadLine();
            Console.WriteLine("Hi there, " + name + "!" + " This is a calculator app.");

            string? value = null;
            int max_tries = 3;

            do
            {
                int result;

                var num1 = 0;
                var currentTryCount = 0;
                num1 = GetUserInput("Enter first number: ", max_tries, ref currentTryCount);

                if (num1 == 0 && currentTryCount == max_tries)
                {
                    goto AskDoYouWantToContinue;
                }

                var num2 = 0;
                currentTryCount = 0;
                num2 = GetUserInput("Enter second number: ", max_tries, ref currentTryCount);

                if (num2 == 0 && currentTryCount == max_tries)
                {
                    goto AskDoYouWantToContinue;
                }

                Console.WriteLine("You have entered {0}, {1}", num1, num2);

                Console.Write("Now enter '+' to add these numbers; '-' to subtract; '*' to multiply; or '/' to divide: ");
                string? symbol = Console.ReadLine();

                result = Calculate(num1, num2, symbol);
                Console.WriteLine($"The result is: {num1}{symbol}{num2} = {result}");

                AskDoYouWantToContinue:
                Console.Write("Do you want to continue (Y / N):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }

        private static int GetUserInput(string messageOnTheScreen, int maxTryCount, ref int currentTryCount)
        {
            int userInputNumber = 0;

            while (currentTryCount < maxTryCount)
            {
                Console.Write(messageOnTheScreen);
                string? userInput = Console.ReadLine();

                currentTryCount += 1;

                if (int.TryParse(userInput, out userInputNumber) == false)
                {
                    Console.WriteLine("Attempt {0}. Invalid input: {1}", currentTryCount, userInput);
                }
                else
                {
                    // if we can successfully parse user input, meaning it's a valid number, then break out of the while loop
                    break;
                }
            }

            return userInputNumber;
        }

        private static int Calculate(int num1, int num2, string? opSymbol)
        {
            int result = 0;

            if(opSymbol is null)
            {
                return result;
            }

            switch (opSymbol)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                    break;
            }

            return result;
        }
    }
}
