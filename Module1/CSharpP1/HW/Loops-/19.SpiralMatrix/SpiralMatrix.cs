using System;
//Problem 19.** Spiral Matrix
//Write a program that reads from the console a positive integer number n (1 = n = 20) 
//and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
class SpiralMatrix
{
    enum direction
    {
        right,
        left,
        down,
        up,
    }
    static int row = 0;
    static int col = 0;
    static direction dir = direction.right;
    static int[,] elements;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        elements = new int[n , n];
        for (int i = 0; i < elements.GetLength(0); i++)
        {
            for (int j = 0; j < elements.GetLength(1); j++)
            {
                elements[i, j] = 0;
            }           
        }
        for (int i = 1; i <= n*n; i++)
        {
            elements[row, col] = i;
            Move();
        }
        for (int y = 0; y < elements.GetLength(1); y++)
        {
            for (int x = 0; x < elements.GetLength(0); x++)
            {
                Console.Write("{0,3}", elements[y,x]);
            }
            Console.WriteLine();
        }
    }
    static void Move()
    {
        if (dir == direction.right)
        {
            if (col + 1 >= elements.GetLength(1))
            {
                dir = direction.down;
                row++;
            }
            else if (elements[row, col + 1] != 0)
            {
                dir = direction.down;
                row++;
            }
            else
            {
                col++;
            }
        }
        else if (dir == direction.down)
        {
            if (row + 1 >= elements.GetLength(0))
            {
                dir = direction.left;
                col--;
            }
            else if (elements[row + 1, col] != 0)
            {
                dir = direction.left;
                col--;
            }
            else
            {
                row++;
            }
        }
        else if (dir == direction.left)
        {
            if (col - 1 < 0)
            {
                dir = direction.up;
                row--;
            }
            else if (elements[row, col - 1] != 0)
            {
                dir = direction.up;
                row--;
            }
            else
            {
                col--;
            }
        }
        else if (dir == direction.up)
        {
            if (row - 1 < 0)
            {
                dir = direction.right;
                col++;
            }
            else if (elements[row - 1, col] != 0)
            {
                dir = direction.right;
                col++;
            }
            else
            {
                row--;
            }
        }
    }
}
