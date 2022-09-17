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
            do
            {
                int result;

            firstUserInputLabel:
                Console.Write("Enter first number: ");
                string? firstUserInput = Console.ReadLine();

                int firstUserInputTryCount = 0;

                if (int.TryParse(firstUserInput, out int num1) == false)
                {
                    Console.WriteLine("Invalid input: {0}", firstUserInput);
                    firstUserInputTryCount += 1;
                    Console.WriteLine("firstUserInputTryCount: "+ firstUserInputTryCount);
                    if (firstUserInputTryCount <= 3)
                    {
                        goto firstUserInputLabel;
                    }
                    else
                    {
                        goto AskDoYouWantToContinue;
                    }
                }

            secondUserInputLabel:
                Console.Write("Enter second number: ");
                string? secondUserInputLabel = Console.ReadLine();

                if (int.TryParse(secondUserInputLabel, out int num2) == false)
                {
                    Console.WriteLine("Invalid input: {0}", secondUserInputLabel);
                    goto secondUserInputLabel;
                }

                Console.WriteLine("You have entered {0}, {1}", num1, num2);

                Console.Write("Now enter '+' to add these numbers; '-' to subtract; '*' to multiply; or '/' to divide: ");
                string? symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Result: " + result);
                        Console.Write("Do you want to continue (Y / N):");
                        value = Console.ReadLine();
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Result: " + result);
                        Console.Write("Do you want to continue (Y / N):");
                        value = Console.ReadLine();
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("Result: " + result);
                        Console.Write("Do you want to continue (Y / N):");
                        value = Console.ReadLine();
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                        Console.Write("Do you want to continue (Y / N):");
                        value = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        Console.Write("Do you want to continue (Y / N):");
                        value = Console.ReadLine();
                        break;
                }
                Console.ReadLine();
                AskDoYouWantToContinue:
                Console.Write("Do you want to continue (Y / N):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }


    }
}
