using System;
/*
 * Problem 7. Quotes in Strings
Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined.
 */
class QuotesInStrings
{
    static void Main()
    {
        string firstStrVar = "The \"use\" of quotations causes difficulties.";
        string secondStrVar = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(firstStrVar);
        Console.WriteLine(secondStrVar);

    }
}
