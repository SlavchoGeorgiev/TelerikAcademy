using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfPage
{
    class GameOfPage
    {
        static int buyCookieNum = 0;
        static List<string> finalResult = new List<string>(); 
        static void Main()
        {
            double cooiePrice = 1.79;
            int traySize = 16;
            int row, col;
            int[,] tray = new int[traySize, traySize];
            for (int y = 0; y < traySize; y++)
            {
                string inputLine = Console.ReadLine();
                for (int x = 0; x < traySize; x++)
                {
                    tray[y, x] = int.Parse(inputLine[x].ToString());
                }
            }
            while (true)
            {
                string pageSay = Console.ReadLine();
                if (pageSay == "paypal")
                {
                    Console.WriteLine("{0:F2}", buyCookieNum * cooiePrice);
                    //finalResult.Add(string.Format("{0}", buyCookieNum * cooiePrice));
                    break;
                }
                row = int.Parse(Console.ReadLine());
                col = int.Parse(Console.ReadLine());
                WhatIs(pageSay, row, col, tray);
            }
            foreach (var line in finalResult)
            {
                Console.WriteLine(line);
            }
            //////Print tray
            //Console.WriteLine();
            //for (int i = 0; i < traySize; i++)
            //{
            //    for (int j = 0; j < traySize; j++)
            //    {
            //        Console.Write(tray[i, j]);
            //    }
            //    Console.WriteLine();
            //}
        }

        static void WhatIs(string action, int row, int col, int[,] tray)
        {
            if (action == "what is")
            {
                if (IsItCookie(row, col, tray))
                {
                    Console.WriteLine("cookie");
                    //finalResult.Add("cookie");
                }
                else if (IsItBrokenCookie(row, col, tray))
                {
                    Console.WriteLine("broken cookie");
                    //finalResult.Add("broken cookie");
                }
                else if (tray[row, col] == 1)
                {
                    Console.WriteLine("cookie crumb");
                    //finalResult.Add("cookie crumb");
                }
                else
                {
                    Console.WriteLine("smile");
                    //finalResult.Add("smile");
                }
            }
            else if (action == "buy")
            {
                if (IsItCookie(row, col, tray))
                {
                    DeleteCookie(row, col, tray);
                    buyCookieNum++;
                }
                else if (tray[row, col] == 1)
                {
                    Console.WriteLine("page");
                    //finalResult.Add("page");
                }
                else
                {
                    Console.WriteLine("smile");
                   //finalResult.Add("smile");
                } 
            }
        }

        static void DeleteCookie(int row, int col, int[,] tray)
        {
            for (int y = row - 1; y <= row + 1; y++)
            {
                for (int x = col - 1; x <= col + 1; x++)
                {
                    tray[y, x] = 0;
                }
            }
        }
        static bool IsItCookie(int row, int col, int[,] tray)
        {
            bool isIt = true;
            for (int y = row - 1; y <= row + 1; y++)
			{
                for (int x = col - 1; x <= col + 1; x++)
		        {
                    if (y < tray.GetLength(0) && y >= 0 && x < tray.GetLength(1) && x >= 0)
                    {
                        if (tray[y,x] == 0)
                        {
                            isIt = false;
                        }
                    }
                    else
                    {
                        isIt = false;
                    }
		        }
			}
            return isIt;
        }
        static bool IsItBrokenCookie(int row, int col, int[,] tray)
        {
            bool result = false;
            if (tray[row, col] == 0)
            {
                return false;
            }
            for (int y = row - 1; y <= row + 1; y++)
            {
                for (int x = col - 1; x < col + 1; x++)
                {
                    if (y < tray.GetLength(0) && y >= 0 && x < tray.GetLength(1) && x >= 0)
                    {
                        if (tray[y, x] == 1 && (y != row || x != col) )
                        {
                            result = true;
                        }
                    }
                }
            }
            return result;
        }
        //static bool IsItBrokenCookie(int row, int col, int[,] tray)
        //{
        //    bool result = false;
        //    for (int y = row - 1; y <= row + 1; y++)
        //    {
        //        for (int x = col - 1; x < col + 1; x++)
        //        {
        //            if (y < tray.GetLength(0) && y >= 0 && x < tray.GetLength(1) && x >= 0)
        //            {
        //                if (IsItCookie(y, x, tray))
        //                {
        //                    result = true;
        //                }
        //            }
        //        }
        //    }
        //    return result;
        //}
    }
}
