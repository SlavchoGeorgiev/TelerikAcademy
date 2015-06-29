using System;
class PrintSequenceSimple
{
    static void Main()
    {
        int signChanger = -1;
        for (int currNum = 2; currNum <= 11; currNum++)
        {
            signChanger = signChanger * -1;
            Console.Write("{0}, ", currNum * signChanger);
        }
    }
}
