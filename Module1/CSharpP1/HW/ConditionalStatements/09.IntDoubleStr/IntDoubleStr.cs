using System;
//Problem 9. Play with Int, Double and String
//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
class IntDoubleStr
{
    static void Main()
    {
        int firstInput;
        double secondInput;
        string thirdInput;
        Console.WriteLine("Please enter:");
        Console.WriteLine("1 for int;");
        Console.WriteLine("2 for double;");
        Console.WriteLine("3 for string.");
        Console.Write("Choice : ");
        int swNum = int.Parse(Console.ReadLine());
        switch (swNum)
        {
            case 1 : 
                Console.WriteLine("Please enter integer number:");
                firstInput = int.Parse(Console.ReadLine());
                firstInput = firstInput + 1;
                Console.WriteLine("Result: {0}", firstInput);
                break;
            case 2:
                Console.WriteLine("Please enter real number:");
                secondInput = double.Parse(Console.ReadLine());
                secondInput = secondInput + 1;
                Console.WriteLine("Result: {0}", secondInput);
                break;
            case 3:
                Console.WriteLine("Please enter string:");
                thirdInput = Console.ReadLine();
                thirdInput = thirdInput + "*";
                Console.WriteLine("Result: {0}", thirdInput);
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    }
}