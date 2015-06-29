namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    class StartPoint
    {
        static void Main()
        {
            List<Discipline> disciplines = new List<Discipline>();
            List<Student> students = new List<Student>();
            for (int i = 0; i < 15; i++)
            {
                disciplines.Add(new Discipline(string.Format("Discipline {0}", i + 1), i * 2 + 1, i * 3 + 2));
                students.Add(new Student(string.Format("Pesho {0}{1}{0}", (char)(66 + i), (char)(65 + i)),i + 1));
            }

            List<Teacher> teachers = new List<Teacher>() { 
                new Teacher("Ivanka Petrova") { Disciplines = disciplines, Comment = "Pechena e :)"},
                new Teacher("Gergana Ivanova") { Disciplines = {disciplines[0], disciplines[6], disciplines[8]}, Comment = "Stava :)"},
                new Teacher("Poli Hristova") { Disciplines = {disciplines[4], disciplines[5], disciplines[7]}, Comment = "Losha :)"},
                new Teacher("Velichka Andreeva") { Disciplines = {disciplines[8], disciplines[12], disciplines[14]}, Comment = "Stava :)"}
            };
            Class myClass = new Class("8a", students, teachers);
            School mySchool = new School();
            mySchool.Name = "Hristo Botev";
            mySchool.Classes.Add(myClass);
            Console.WriteLine("School name: {0}", mySchool.Name);
            foreach (var pClass in mySchool.Classes)
            {
                Console.WriteLine("  Class: {0}", pClass.TextIdentifier);
                Console.WriteLine("  Students: ");
                foreach (var st in pClass.Students)
                {
                    Console.WriteLine("    Name: {0}, Num: {1}", st.Name, st.ClassNumber);
                }

                Console.WriteLine("  Teachers: ");
                foreach (var teach in pClass.Teachers)
                {
                    Console.WriteLine("    Name: {0}",teach.Name);
                    Console.WriteLine("    Disciplines: ");
                    foreach (var disc in teach.Disciplines)
                    {
                        Console.WriteLine("       {0} Lectures: {1}, Exercises: {2}", disc.Name, disc.NumLectures, disc.NumExercises);
                    }
                }
            }

        }
    }
}
