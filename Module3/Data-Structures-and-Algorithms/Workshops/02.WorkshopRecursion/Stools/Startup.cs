namespace Stools
{
    using System;

    public class Stool
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }

    public enum SideHeight
    {
        X = 0,
        Y = 1,
        Z = 2
    }

    public class Startup
    {
        public static int n;
        public static Stool[] stools;
        public static int?[,,] maxTowerMemo;

        static void Main()
        {
            n = int.Parse(Console.ReadLine());
            stools = new Stool[n];

            maxTowerMemo = new int?[n, 1 << n, 3];

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                stools[i] = new Stool() { X = int.Parse(line[0]), Y = int.Parse(line[1]), Z = int.Parse(line[2]) };
            }

            int result = 0;
            int used = (1 << n) - 1;

            for (int i = 0; i < n; i++)
            {
                if (stools[i].X == stools[i].Y && stools[i].Y == stools[i].Z)
                {
                    result = Math.Max(result, MaxTower(i, used ^ (1 << i), SideHeight.X));
                }
                else
                {
                    result = Math.Max(result, MaxTower(i, used ^ (1 << i), SideHeight.X));
                    result = Math.Max(result, MaxTower(i, used ^ (1 << i), SideHeight.Y));
                    result = Math.Max(result, MaxTower(i, used ^ (1 << i), SideHeight.Z));
                }
            }

            Console.WriteLine(result);
        }

        public static int MaxTower(int index, int used, SideHeight sideHeight)
        {

            if (maxTowerMemo[index, used, (int)sideHeight] != null)
            {
                return (int)maxTowerMemo[index, used, (int)sideHeight];
            }

            int currentX;
            int currentY;
            int currentHeight;

            switch (sideHeight)
            {
                case SideHeight.X:
                    currentHeight = stools[index].X;
                    currentX = stools[index].Y;
                    currentY = stools[index].Z;
                    break;
                case SideHeight.Y:
                    currentHeight = stools[index].Y;
                    currentX = stools[index].X;
                    currentY = stools[index].Z;
                    break;
                default:
                    currentHeight = stools[index].Z;
                    currentX = stools[index].Y;
                    currentY = stools[index].X;
                    break;
            }

            var result = 0;

            if (used != 1 << index)
            {
                for (int i = 0; i < n; i++)
                {
                    if ((used & (1 << i)) != 0)
                    {
                        var nextStool = stools[i];

                        if (nextStool.X == nextStool.Y && nextStool.Y == nextStool.Z)
                        {
                            if (currentX >= nextStool.X && currentY >= nextStool.Y ||
                                currentX >= nextStool.Y && currentY >= nextStool.X)
                            {
                                result = Math.Max(MaxTower(i, used ^ (1 << i), SideHeight.Z), result);
                            }
                        }
                        else
                        {
                            if (currentX >= nextStool.X && currentY >= nextStool.Y ||
                                currentX >= nextStool.Y && currentY >= nextStool.X)
                            {
                                result = Math.Max(MaxTower(i, used ^ (1 << i), SideHeight.Z), result);
                            }

                            if (currentX >= nextStool.X && currentY >= nextStool.Z ||
                                currentX >= nextStool.Z && currentY >= nextStool.X)
                            {
                                result = Math.Max(MaxTower(i, used ^ (1 << i), SideHeight.Y), result);
                            }

                            if (currentX >= nextStool.Y && currentY >= nextStool.Z ||
                                currentX >= nextStool.Z && currentY >= nextStool.Y)
                            {
                                result = Math.Max(MaxTower(i, used ^ (1 << i), SideHeight.X), result);
                            }
                        }
                    }
                }
                maxTowerMemo[index, used, (int)sideHeight] = result + currentHeight;
                return result + currentHeight;
            }
            else
            {
                maxTowerMemo[index, used, (int)sideHeight] = currentHeight;
                return currentHeight;
            }
        }
    }
}
