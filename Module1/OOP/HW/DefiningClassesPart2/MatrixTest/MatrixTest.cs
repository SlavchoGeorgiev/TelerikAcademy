using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClasses;

namespace MatrixTest
{
    class MatrixTest
    {
        static void Main()
        {
            Matrix<int> testMTX = new Matrix<int>(5, 5);
            for (int row = 0; row < testMTX.Rows; row++)
            {
                for (int col = 0; col < testMTX.Cols; col++)
                {
                    testMTX[row, col] = row + col;
                }
            }

            Console.WriteLine("Matrix 1:");
            Console.WriteLine(testMTX);
            Matrix<int> nextMTX = new Matrix<int>(5, 5);
            for (int row = 0; row < nextMTX.Rows; row++)
            {
                for (int col = 0; col < nextMTX.Cols; col++)
                {
                    nextMTX[row, col] = row + col * 2 + 5;
                }
            }

            Console.WriteLine("Matrix 2:");
            Console.WriteLine(nextMTX);
            Console.WriteLine("Sum:");
            Console.WriteLine((testMTX + nextMTX));
            Console.WriteLine("Subtraction:");
            Console.WriteLine((testMTX - nextMTX));
            Console.WriteLine("Multiplication:");
            Console.WriteLine((testMTX * nextMTX));
            Console.WriteLine("Matrix 1 is {0}!", testMTX ? "not empty" : "empty");
            Console.WriteLine("This empty matrix:\n{1}is {0}!" + Environment.NewLine, new Matrix<double>(5, 5) ? "not empty" : "empty", new Matrix<double>(5, 5));
        }
    }
}
