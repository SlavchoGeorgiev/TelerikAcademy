namespace TraverseDirectory
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            PrintAllExeFiles(@"C://Windows");
        }

        public static void PrintAllExeFiles(string path)
        {

            IEnumerable<string> files;
            try
            {
                files = Directory.EnumerateFiles(path);
            }
            catch (Exception ex)
            {
                return;
            }

            foreach (var file in files)
            {
                if (file.IndexOf(".") >= 0)
                {
                    if (file.Substring(file.LastIndexOf('.'), file.Length - file.LastIndexOf('.')).ToLower() == ".exe")
                    {
                        Console.WriteLine(file);
                    }
                }
            }

            var folders = Directory.EnumerateDirectories(path);

            foreach (var folder in folders)
            {
                PrintAllExeFiles(folder);
            }
        }
    }
}
