namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Test
    {
        static void Main()
        {
            List<Student> testStudents = new List<Student>();
            List<Worker> testWorkers = new List<Worker>();
            Random rg = new Random();
            for (int i = 0; i < 10; i++)
            {
                testStudents.Add(new Student(string.Format("{0}{1}{2}{3}{0}{3}", (char)rg.Next(65,90), (char)rg.Next(65,90), (char)rg.Next(65,90), (char)rg.Next(65,90)), string.Format("{0}{1}{2}{1}{0}{3}{0}{3}", (char)rg.Next(65,90), (char)rg.Next(65,90), (char)rg.Next(65,90), (char)rg.Next(65,90)), rg.Next(2,6)));
                testWorkers.Add(new Worker(string.Format("{0}{1}{0}{3}{0}{3}", (char)rg.Next(65,90), (char)rg.Next(65,90), (char)rg.Next(65,90), (char)rg.Next(65,90)), string.Format("{0}{1}{2}{1}{0}{3}{0}{3}", (char)rg.Next(65,90), (char)rg.Next(65,90), (char)rg.Next(65,90), (char)rg.Next(65,90)), rg.Next(500, 3000), rg.Next(1,24)));
            }
            var sortedStudenstByGrade = testStudents.OrderBy(s => s.Grade).ToList<Human>();
            foreach (var student in sortedStudenstByGrade)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            var sortedWorkersByMPH = testWorkers.OrderByDescending(w => w.MoneyPerHour()).ToList<Human>();
            foreach (var worker in sortedWorkersByMPH)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();
            List<Human> mergedHumans = sortedStudenstByGrade
                .Union(sortedWorkersByMPH)
                .OrderBy(h => h.LastName)
                .OrderBy(h => h.FirstName)
                .ToList();
            foreach (var human in mergedHumans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
