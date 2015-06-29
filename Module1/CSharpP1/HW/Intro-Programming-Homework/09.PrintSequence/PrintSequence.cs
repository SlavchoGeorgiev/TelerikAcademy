using System;

public class PrintSequence
{
    static void Main()
    {
        int seedNumber = 2;
        int seqenceLenght = 10;
        int step = 1;
        PrintThisSequence(seedNumber, seqenceLenght, step);
    }

    public static void PrintThisSequence(int seedNumber, int seqenceLenght, int step)
    {
        int element = seedNumber;
        int signChanger = -1;
        if (element < 0)
        {
            signChanger = signChanger * -1;
        }
        Console.Write(element);
        for (int i = 1; i < seqenceLenght; i++)
        {
            element = signChanger * (Math.Abs(element) + step);
            Console.Write(", {0}", element);
            signChanger = signChanger * -1;
        }
    }
}