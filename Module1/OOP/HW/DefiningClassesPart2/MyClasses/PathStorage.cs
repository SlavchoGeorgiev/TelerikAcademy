namespace MyClasses
{
    using System;
    using System.IO;
    using System.Text;

    public static class PathStorage
    {
        public static void Save(Path path, string url)
        {
            var pathFile = new StreamWriter(url, false, Encoding.GetEncoding(1251));
            using (pathFile)
            {
                foreach (var point in path.Points)
                {
                    string currLine = string.Format("{0},{1},{2}", point.X, point.Y, point.Z);
                    pathFile.WriteLine(currLine);
                }
            }
        }

        public static Path Load(string url)
        {
            Path loadedPath = new Path();
            var fileToLoad = new StreamReader(url, Encoding.GetEncoding(1251));
            using (fileToLoad)
            {
                string line = fileToLoad.ReadLine();
                while (line != null)
                {
                    var point = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    double x = double.Parse(point[0]);
                    double y = double.Parse(point[1]);
                    double z = double.Parse(point[2]);
                    loadedPath.AddPoint(new Point3D(x, y, z));
                    line = fileToLoad.ReadLine();
                }
            }

            return loadedPath;
        }
    }
}
