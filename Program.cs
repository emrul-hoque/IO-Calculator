using System;
using System.IO;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("What is your name? ");
            string? name = Convert.ToString(Console.Read());
            Console.WriteLine("Hi there, " + name + "!" + " This is a calculator app.");

            string? value = null;
            do
            {
                int result;
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.Read());
                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.Read());
                Console.WriteLine("Now enter '+' to add these numbers; '-' to subtract; '*' to multiply; or '/' to divide: ");
                string? symbol = Convert.ToString(Console.Read());

                switch (symbol)
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
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }

    }   
}
