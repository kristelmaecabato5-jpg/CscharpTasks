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
            
            int operation = int.Parse(Console.ReadLine());
            
            Console.Write("Enter Value 1: ");
            double value1 = double.Parse(Console.ReadLine());
            
            Console.Write("Enter Value 2: ");
            double value2 = double.Parse(Console.ReadLine());
            
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
                default:
                    Console.WriteLine("Invalid operation choice!");
                    continue;
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
