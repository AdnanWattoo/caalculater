using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Console Calculator!");

        Console.Write("Enter first number: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
            return;
        }

        Console.Write("Enter operator (+, -, *, /): ");
        if (!char.TryParse(Console.ReadLine(), out char op) || "+-*/".IndexOf(op) == -1)
        {
            Console.WriteLine("Invalid operator! Use +, -, *, or /.");
            return;
        }

        Console.Write("Enter second number: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
            return;
        }

        double result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero!");
                    return;
                }
                break;
        }

        Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
    }
}
