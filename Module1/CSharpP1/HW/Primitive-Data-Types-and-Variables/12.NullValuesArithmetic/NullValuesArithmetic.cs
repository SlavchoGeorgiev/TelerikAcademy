using System;
/*Problem 12. Null Values Arithmetic
Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/
class NullValuesArithmetic
{
    static void Main()
    {
        int? intVar = null;
        double? doubleVar = null;
        Console.WriteLine(intVar);
        Console.WriteLine(doubleVar);
        intVar = intVar + 1;
        Console.WriteLine(intVar);
        intVar += null;
        Console.WriteLine(intVar);
        doubleVar += 3.14d;
        Console.WriteLine(doubleVar);
        doubleVar += null;
        Console.WriteLine(doubleVar);
    }
}