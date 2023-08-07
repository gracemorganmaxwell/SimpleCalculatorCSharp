using System;

namespace SimpleCalculator
{
    public static class Calculator
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Simple Calculator,");
            Console.WriteLine("please input the two numbers and the arithmetic operation you wish to be calculated.");

            // Read the first number
            Console.WriteLine("Enter the first number:");
            double number1;
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
                        // Read the second number
            Console.WriteLine("Enter the second number:");
            double number2;
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Ask for the operation
            Console.WriteLine("Enter the operation (+, -, *, /):");
            string operation = Console.ReadLine();

            double result;
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 == 0) // Check for division by zero
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please use +, -, *, or /.");
                    return;
            }

            Console.WriteLine($"The result of {number1} {operation} {number2} is: {result}");
        }
    }
}
