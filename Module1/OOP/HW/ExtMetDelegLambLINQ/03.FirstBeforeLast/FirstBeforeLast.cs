namespace _03.FirstBeforeLast
{
    using System;
    using MyStudent;
    using System.Linq;

    class FirstBeforeLast
    {
        static void Main()
        {
            Student[] students = {new Student(){FirstName = "Pesho", LastName = "Goshov"},
                                  new Student(){FirstName = "Ivajlo", LastName = "Nikov"},
                                  new Student(){FirstName = "Vlado", LastName = "Hristov"},
                                  new Student(){FirstName = "Jordan", LastName = "Draganov"},
                                  new Student(){FirstName = "Andrej", LastName = "Ivanov"},
                                  new Student(){FirstName = "Rumen", LastName = "Nikolov"}};
            foreach (var student in FirstLastNameCompare(students))
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
            Console.WriteLine();
            foreach (var student in FirstLastNameCompareLinq(students))
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
        private static Student[] FirstLastNameCompare(Student[] students)
        {
            return students
                .Where(x => x.FirstName.CompareTo(x.LastName) < 0)
                .Select(x => x)
                .ToArray<Student>();
        }

        private static Student[] FirstLastNameCompareLinq(Student[] students)
        {
            var result = from student in students 
                         where student.FirstName.CompareTo(student.LastName) < 0 
                         select student;
            return result.ToArray();
        }
    }
}
