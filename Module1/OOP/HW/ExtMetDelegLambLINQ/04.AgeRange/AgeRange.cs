namespace _04.AgeRange
{
    using System;
    using System.Linq;
    using MyStudent;

    class AgeRange
    {
        static void Main()
        {

            Student[] students = {new Student(){FirstName = "Pesho", LastName = "Goshov", Age = 20},
                                  new Student(){FirstName = "Ivajlo", LastName = "Nikov", Age = 17},
                                  new Student(){FirstName = "Vlado", LastName = "Hristov", Age = 16},
                                  new Student(){FirstName = "Jordan", LastName = "Draganov", Age = 25},
                                  new Student(){FirstName = "Andrej", LastName = "Ivanov", Age = 24},
                                  new Student(){FirstName = "Rumen", LastName = "Nikolov", Age = 21}};
            var filtredSudents =
                students
                .Where(s => s.Age <= 24 && s.Age >= 18)
                .Select(s => String.Format("{0} {1}", s.FirstName, s.LastName));
            foreach (var studentName in filtredSudents)
            {
                Console.WriteLine(studentName);
            }
        }
    }
}
