using System;

class PrintNameAtSeparateLines
{
    static void Main()
    {
        string firstName = "Hristo";
        string lastName = "Georgiev";
        Console.WriteLine("My first name is {0}.", firstName);
        Console.WriteLine("My last name is {0}.", lastName);
        Console.Write("Please enter your first name: ");
        firstName = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        lastName = Console.ReadLine();
        string yourFullName = firstName + " " + lastName;
        Console.WriteLine("Hello {0}!", yourFullName);
    }
}
