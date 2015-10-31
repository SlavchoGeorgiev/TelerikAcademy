using System;
using System.Collections.Generic;
using System.Linq;

public class LoverOf3
{
    private static int rowPosition = 0;
    private static int colPosition = 0;

    public static void Main()
    {
        string[] firstLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int rows = int.Parse(firstLine[0]);
        int cols = int.Parse(firstLine[1]);
        int numberOfMoves = int.Parse(Console.ReadLine());

        int[,] field = GenerateField(rows, cols);

        long result = 0;
        for (int i = 0; i < numberOfMoves; i++)
        {
            string[] nextLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string nextDirection = nextLine[0];
            int movesPerDirection = int.Parse(nextLine[1]);
            result += Move(field, nextDirection, movesPerDirection);
        }

        Console.WriteLine(result);
    }

    private static int[,] GenerateField(int rows, int cols)
    {
        int[,] field = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                field[i, j] = 3 * (i + j);
            }
        }

        return field;
    }

    private static long Move(int[,] field, string d, int k)
    {
        int result = field[rowPosition, colPosition];
        field[rowPosition, colPosition] = 0;

        while (k > 1 && MoveToNext(field, d))
        {
            k--;
            result += field[rowPosition, colPosition];
            field[rowPosition, colPosition] = 0;
        }

        return result;
    }

    private static bool MoveToNext(int[,] field, string d)
    {
        int nextR = rowPosition;
        int nextC = colPosition;

        if (d == "RU" || d == "UR")
        {
            nextC++;
            nextR++;
        }
        else if (d == "LU" || d == "UL")
        {
            nextC--;
            nextR++;
        }
        else if (d == "DL" || d == "LD")
        {
            nextC--;
            nextR--;
        }
        else if (d == "DR" || d == "RD")
        {
            nextC++;
            nextR--;
        }

        if (nextR >= 0 && nextC >= 0 && nextR < field.GetLength(0) && nextC < field.GetLength(1))
        {
            rowPosition = nextR;
            colPosition = nextC;

            return true;
        }
        else
        {
            return false;
        }
    }
}
