namespace _05.OrderStudentsByName
{
    using System;
    using System.Linq;
    using MyStudent;

    class OrderStudentsByName
    {
        static void Main()
        {
            Student[] students = {new Student(){FirstName = "Pesho", LastName = "Goshov", Age = 20},
                                  new Student(){FirstName = "Ivajlo", LastName = "Nikov", Age = 17},
                                  new Student(){FirstName = "Ivajlo", LastName = "Apostolov", Age = 17},
                                  new Student(){FirstName = "Vlado", LastName = "Hristov", Age = 16},
                                  new Student(){FirstName = "Jordan", LastName = "Draganov", Age = 25},
                                  new Student(){FirstName = "Andrej", LastName = "Ivanov", Age = 24},
                                  new Student(){FirstName = "Rumen", LastName = "Nikolov", Age = 21}};
            var orderedStudent = students
                .OrderBy(s => s.FirstName)
                .ThenBy(s => s.LastName);
            foreach (var student in orderedStudent)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            var orededByLinq = from student in students orderby student.LastName orderby student.FirstName select student;
            Console.WriteLine();
            foreach (var student in orededByLinq)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
