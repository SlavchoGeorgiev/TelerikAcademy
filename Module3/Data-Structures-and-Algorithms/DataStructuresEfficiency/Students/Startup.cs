namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var students = new SortedDictionary<string, SortedDictionary<string, Student>>();

            using (var sr = new StreamReader(@"..\..\students.txt"))
            {
                var line = sr.ReadLine();
                
                while (line != null)
                {
                    var values = line
                        .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(v => v.Trim())
                        .ToArray();

                    var student = new Student(values[0], values[1]);

                    if (!students.ContainsKey(values[2]))
                    {
                        students.Add(values[2], new SortedDictionary<string, Student>());
                    }

                    if (!students[values[2]].ContainsKey(student.ToString()))
                    {
                        students[values[2]].Add(student.ToString(), student);
                    }

                    line = sr.ReadLine();
                }
            }

            foreach (var course in students)
            {
                Console.Write("{0}: ", course.Key);
                List<string> studentsInCourse = new List<string>();

                foreach (var student in course.Value)
                {
                    studentsInCourse.Add(student.Value.FirstName + " " + student.Value.LastName);
                }

                Console.WriteLine(string.Join(", ", studentsInCourse));
            }
        }
    }
}
