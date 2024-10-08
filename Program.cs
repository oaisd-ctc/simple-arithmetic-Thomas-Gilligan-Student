using System;

public static class Program {

    public static void Main(string[] args) {

        Console.Clear();
        Console.WriteLine("Provide a starting number to perform an arithmetic operation with.");
        float term1 = float.Parse(Console.ReadLine());

        Console.WriteLine($"{term1}...got it. Provide a second number to operate with {term1}.");
        float term2 = float.Parse(Console.ReadLine());

        Console.WriteLine("What operation would you like to perform? (e.g. +, -, *, /, int/, %)");
        string operation = Console.ReadLine();

        if (operation == null) {
            throw new Exception("Please enter one of the listed operators.");
        }

        string[] operators = ["+", "-", "*", "/", "int/", "%"];

        bool testOperation = false;

        foreach (string op in operators) {
            if (op == operation) {
                testOperation = true;
                break;
            }
        }

        float result = 0;
        if (testOperation == true) {
            result = Solve(operation, term1, term2);
        } else {
            throw new Exception("Please enter one of the listed operators.");
        }

        Console.WriteLine($"Alright! That's easy. {term1} {operation} {term2} is {result}.");

    }

    public static float Solve(this string operation, float term1, float term2) {

        switch (operation) {
            case "+": return term1 + term2;
            case "-": return term1 - term2;
            case "*": return term1 * term2;
            case "/": return term1 / term2;
            case "int/": return (float)Math.Floor(term1 / term2);
            case "%": return term1 % term2;
            default: throw new Exception("Please enter one of the listed operators.");
        }        

    }

}