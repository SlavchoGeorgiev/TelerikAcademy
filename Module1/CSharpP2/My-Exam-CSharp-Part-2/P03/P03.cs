using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class P03
{
    static int rPosition = 0;
    static int cPosition = 0;
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int r = int.Parse(firstLine[0]);
        int c = int.Parse(firstLine[1]);
        int n = int.Parse(Console.ReadLine());
        int[,] field = new int[r, c];
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                field[i, j] = 3 * (i + j);
            }   
        }
        //for (int i = 0; i < r; i++)
        //{
        //    for (int j = 0; j < c; j++)
        //    {
        //        Console.Write(field[i, j]);
        //    }
        //    Console.WriteLine();
        //}
        long result = 0;
        for (int i = 0; i < n; i++)
        {
            string[] nLinie = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string d = nLinie[0];
            int k = int.Parse(nLinie[1]);
            result += Move(field, d, k);
        }
        Console.WriteLine(result);
    }

    private static long Move(int[,] field, string d, int k)
    {
        int result = field[rPosition, cPosition];
        field[rPosition, cPosition] = 0;
        //Console.WriteLine(field[rPosition, cPosition]);
        while (k > 1 && MoveToNext(field, d))
        {
            k--;
            //Console.WriteLine(field[rPosition, cPosition]);
            result += field[rPosition, cPosition];
            field[rPosition, cPosition] = 0;
        }
        return result;
    }

    private static bool MoveToNext(int[,] field, string d)
    {
        int nextR = rPosition;
        int nextC = cPosition;
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
            rPosition = nextR;
            cPosition = nextC;
            return true;
        }
        else
        {
            return false;
        }
    }
}
