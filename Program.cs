using System;

class Program
{
    static Calculator calc = new Calculator();

    static void Main()
    {

        while (true)
        {
            ShowMenu();
            string choice = Console.ReadLine()?.Trim() ?? "";

            switch (choice)
            {
                case "1": PerformCalculation("+"); break;
                case "2": PerformCalculation("-"); break;
                case "3": PerformCalculation("*"); break;
                case "4": PerformCalculation("/"); break;
                case "5": calc.DisplayHistory(); break;
                case "6": calc.SaveHistory(); break;
                case "7": calc.ClearHistory(); break;
                case "0":
                    calc.SaveHistory();
                    Console.WriteLine("\nGoodbye! Thank you for using the calculator.\n");
                    return;
                default:
                    Console.WriteLine("Invalid selection. Please choose between 0–7.");
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("\n1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");
        Console.WriteLine("5. View History");
        Console.WriteLine("6. Save History");
        Console.WriteLine("7. Clear History");
        Console.WriteLine("0. Exit");
        Console.WriteLine("-----------------------------------");
        Console.Write("Select an option: ");
    }

    static void PerformCalculation(string operation)
    {
        double firstNumber = ReadNumber("Enter first number: ");
        double secondNumber = ReadNumber("Enter second number: ");

        double result = operation switch
        {
            "+" => calc.Add(firstNumber, secondNumber),
            "-" => calc.Subtract(firstNumber, secondNumber),
            "*" => calc.Multiply(firstNumber, secondNumber),
            "/" => calc.Divide(firstNumber, secondNumber),
            _ => double.NaN
        };

        if (!double.IsNaN(result))
        {
            Console.WriteLine($"\nResult: {firstNumber} {operation} {secondNumber} = {result}");
        }
    }

    static double ReadNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);

            if (double.TryParse(Console.ReadLine(), out double number))
                return number;

            Console.WriteLine("Invalid input. Please enter a valid numeric value.");
        }
    }
}
