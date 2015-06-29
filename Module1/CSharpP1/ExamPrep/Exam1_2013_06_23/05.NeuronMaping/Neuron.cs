using System;

class Neuron
{
    static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (long.Parse(input) <= -1)
            {
                break;
            }
            ulong inputNumber = ulong.Parse(input);
            ulong mask = 1;
            for (int i = 0; i < 32; i++)
            {
                if ((inputNumber & mask << i) == mask << i)
                {
                    inputNumber = inputNumber & ~(mask << i);
                    if ((inputNumber & mask << (i + 1)) == 0)
                    {
                        for (int writeIndex = i + 1; writeIndex < 32; writeIndex++)
                        {
                            if ((inputNumber & mask << writeIndex) == 0)
                            {
                                inputNumber = inputNumber | (mask << writeIndex);
                            }
                            else
                            {
                                inputNumber = inputNumber & ~(mask << writeIndex);
                                i = writeIndex;
                                break;
                            }
                        }
                    }
                }
            }
            //Console.WriteLine(Convert.ToString(inputNumber,2));
            Console.WriteLine(inputNumber);
        }

    }
}
