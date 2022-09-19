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
            int firstUserInputTryCount = 0;
            int secondUserInputTryCount = 0;

            do
            {
                int result;

            firstUserInputLabel:
                Console.Write("Enter first number: ");
                string? firstUserInput = Console.ReadLine();


                if (int.TryParse(firstUserInput, out int num1) == false)
                {

                    Console.WriteLine("Invalid input: {0}", firstUserInput);

                    if (firstUserInputTryCount < 2)
                    {
                        firstUserInputTryCount += 1;

                        goto firstUserInputLabel;
                    }
                    else
                    {
                        goto AskDoYouWantToContinue;
                    }
                }

            secondUserInputLabel:
                Console.Write("Enter second number: ");
                string? secondUserInput = Console.ReadLine();

                if (int.TryParse(secondUserInput, out int num2) == false)
                {
                    
                    Console.WriteLine("Invalid input: {0}", secondUserInput);
                    if (firstUserInputTryCount < 2)
                    {
                        secondUserInputTryCount += 1;
                        goto secondUserInputLabel;
                    }
                    else
                    {
                        goto AskDoYouWantToContinue;
                    }
                }

                Console.WriteLine("You have entered {0}, {1}", num1, num2);

                Console.Write("Now enter '+' to add these numbers; '-' to subtract; '*' to multiply; or '/' to divide: ");
                string? symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Result: " + result);
                        goto AskDoYouWantToContinue;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Result: " + result);
                        goto AskDoYouWantToContinue;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("Result: " + result);
                        goto AskDoYouWantToContinue;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                        goto AskDoYouWantToContinue;
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
