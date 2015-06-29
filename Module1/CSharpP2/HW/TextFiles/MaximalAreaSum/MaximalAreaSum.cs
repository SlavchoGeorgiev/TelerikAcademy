using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class MaximalAreaSum
{
    static void Main()
    {
        string filePath = @"..\..\Text.txt";
        StreamReader reader = new StreamReader(filePath);
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");
        
        int numberN = 0;
        int[,] matrix;
        using (reader)
        {
            numberN = int.Parse(reader.ReadLine());
            matrix = new int[numberN, numberN];
            for (int row = 0; row < numberN; row++)
            {
                string[] text = reader.ReadLine().Split(' ');
                for (int col = 0; col < numberN; col++)
                { 
                    matrix[row, col] = int.Parse(text[col]);
                }
            }
        }
        int bestSum = int.MinValue;
        for (int row = 0; row < numberN - 1; row++)
        {
            for (int col = 0; col < numberN - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }
        using (writer)
        {
            writer.WriteLine(bestSum);
            Console.WriteLine("SUCCESSFUL");
        }
    }
}

