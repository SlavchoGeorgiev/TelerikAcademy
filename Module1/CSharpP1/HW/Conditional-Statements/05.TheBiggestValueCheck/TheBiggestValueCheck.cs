using System;
/*
 * Problem 5. The Biggest of 3 Numbers
Write a program that finds the biggest of three numbers.
 */
class TheBiggestValueCheck
{
    static void Main()
    {
        double num1, num2, num3;
        do
        {
            Console.Write("X1 = ");
        } while (!(double.TryParse(Console.ReadLine(), out num1)));
        do
        {
            Console.Write("X2 = ");
        } while (!(double.TryParse(Console.ReadLine(), out num2)));
        do
        {
            Console.Write("X3 = ");
        } while (!(double.TryParse(Console.ReadLine(), out num3)));
        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine("{0} is the biggest", num1);
        }
        else
        {
            if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("{0} is the biggest", num2);
            }
            else
            {
                Console.WriteLine("{0} is the biggest", num3);
            }
        }
    }
}
