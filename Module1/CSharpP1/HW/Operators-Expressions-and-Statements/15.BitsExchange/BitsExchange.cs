using System;
/*
 * Problem 15.* Bits Exchange
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
 */
class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter 32-bit unsigned integer: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine(BitExchaneAtPQK.BitExchanger(number, 3, 24, 3));
    }
}
