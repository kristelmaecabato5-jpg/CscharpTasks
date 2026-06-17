using System;

class Task4
{
    static void Main()
    {
        string continueChoice = "Y";
        
        while (continueChoice.ToUpper() == "Y")
        {

            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            
            int operation = 0;
            bool validOperation = false;

            // Input validation for operation choice
            while (!validOperation)
            {
                try
                {
                    operation = int.Parse(Console.ReadLine());
                    if (operation >= 1 && operation <= 4)
                    {
                        validOperation = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation choice! Please enter 1, 2, 3, or 4.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a number (1-4).");
                }
            }

            double value1 = 0;
            double value2 = 0;
            bool validValues = false;

            // Input validation for numeric values
            while (!validValues)
            {
                try
                {
                    Console.Write("Enter Value 1: ");
                    value1 = double.Parse(Console.ReadLine());
                    
                    Console.Write("Enter Value 2: ");
                    value2 = double.Parse(Console.ReadLine());

                    validValues = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter valid numbers.");
                }
            }

            // Validation for division by zero
            if (operation == 4 && value2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
                Console.WriteLine();
                continue;
            }

            double result = 0;
            string operatorSymbol = "";
            
            switch (operation)
            {
                case 1:
                    result = Addition(value1, value2);
                    operatorSymbol = "+";
                    break;
                case 2:
                    result = Subtraction(value1, value2);
                    operatorSymbol = "-";
                    break;
                case 3:
                    result = Multiplication(value1, value2);
                    operatorSymbol = "*";
                    break;
                case 4:
                    result = Division(value1, value2);
                    operatorSymbol = "/";
                    break;
            }
            
            Console.WriteLine($"{value1} {operatorSymbol} {value2} = {result}");
            
            Console.Write("Do you want to continue again (Y/N)? ");
            continueChoice = Console.ReadLine();
            Console.WriteLine();
        }
    }
    
    static double Addition(double a, double b)
    {
        return a + b;
    }
    
    static double Subtraction(double a, double b)
    {
        return a - b;
    }
    
    static double Multiplication(double a, double b)
    {
        return a * b;
    }
    
    static double Division(double a, double b)
    {
        return a / b;
    }
}
