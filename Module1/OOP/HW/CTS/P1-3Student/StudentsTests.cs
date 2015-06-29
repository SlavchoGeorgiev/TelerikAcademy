namespace P1_3Student
{
    using System;
    using System.Collections.Generic;

    public class StudentsTests
    {
        public static void Main()
        {
            List<Student> students = new List<Student> {new Student("Iva", "Petrova", "Dimitrov", 22366, "Sofia, 3 Bacho Kiro str.", "0886666333", "ivka@gmail.com", "C Sharp P1", Specialties.SoftwareTechnology, Universities.SU, Faculties.FMI),
                                                        new Student("Anna", "Avramova", "Aleksieva", 22361, "Sofia, 1 Alabin str.", "0888366664", "anito@yahoo.com", "Marketing", Specialties.Managment, Universities.UNSS, Faculties.Economy)};
            students.Add(students[1].Clone() as Student);
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("Student {0} :", i + 1);
                Console.WriteLine(students[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Equals test: student 1 = student 2 => {0}", students[0].Equals(students[1]));
            Console.WriteLine("Equals test: student 2 = student 3 => {0}", students[1].Equals(students[2]));
            Console.WriteLine();
            Console.WriteLine("Compare test: student 1 compare to student 2 => {0}", students[0].CompareTo(students[1]));
            Console.WriteLine("Compare test: student 2 compare to student 1 => {0}", students[1].CompareTo(students[0]));
            Console.WriteLine("Compare test: student 2 compare to student 3 => {0}", students[1].CompareTo(students[2]));
        }
    }
}
