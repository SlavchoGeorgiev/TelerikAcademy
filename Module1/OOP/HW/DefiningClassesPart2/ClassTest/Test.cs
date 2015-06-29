namespace ClassTest
{
    using System;
    using MyClasses;

    class Test
    {
        private static void Main()
        {
            var p1 = new Point3D(-7, -4, 3);
            var p2 = new Point3D(-17, 6, 2.5);
            Console.WriteLine("Point1: {0}", p1.ToString());
            Console.WriteLine("Point2: {0}", p2.ToString());
            Console.WriteLine("O: {0}", Point3D.O.ToString());
            Console.WriteLine("Distance between {0} and {1} = {2}", p1.ToString(), p2.ToString(), Calc3DSpace.CalculateDistance(p1, p2));
            //Create Path
            var path = new Path();
            path.AddPoint(new Point3D(1, 2, 3));
            path.AddPoint(new Point3D(2, 3, 4));
            path.AddPoint(new Point3D(2, 4, 3)); 
            path.AddPoint(new Point3D(16.5, 2.8, 3.0));
            path.AddPoint(new Point3D(1, 2, 3.1));
            Console.WriteLine("Path:");
            //PrintPath
            foreach (var point in path.Points)
            {
                Console.Write(point.ToString() + " => ");
            }
            Console.WriteLine();
            //Save Path
            Console.WriteLine("Save Path");
            PathStorage.Save(path, @"../../TestPath.csv");
            //Load Path
            Console.WriteLine("Load Path");
            Path loadedPath = PathStorage.Load(@"../../TestPath.csv");
            //Print loaded Path
            Console.Write("Loaded Path:");
            foreach (var point in loadedPath.Points)
            {
                Console.Write(point.ToString() + " => ");
            }
        }
    }
}
