using System;
using System.Collections.Generic;

namespace P1Shapes
{
    class Test
    {
        static void Main()
        {
            List<IShape> testShapes = new List<IShape>();
            for (int i = 1; i < 20; i++)
            {
                //switch (i % 3)
                //{
                //    case 0 : testShapes.Add(new Rectangle(i * 0.3, i * 1.3));
                //        break;
                //    case 1 : testShapes.Add(new Square(i * 0.5));
                //        break;
                //    case 2: testShapes.Add(new Triangle(i * 1.22, i * 3.1));
                //        break;
                //    default:
                //        break;
                //}
                Random rg = new Random(i);
                switch (rg.Next(0,3))
                {
                    case 0: testShapes.Add(new Rectangle(i * rg.NextDouble() * 2, i * rg.NextDouble()));
                        break;
                    case 1: testShapes.Add(new Square(i * rg.NextDouble()));
                        break;
                    case 2: testShapes.Add(new Triangle(i * rg.NextDouble() * 2, rg.NextDouble()));
                        break;
                    default:
                        break;
                }
            }
            foreach (var shape in testShapes)
            {
                Console.WriteLine(shape);
                Console.WriteLine("Surface: {0:F2}", shape.CalculateSurface());
                Console.WriteLine();
            }
        }
    }
}
