namespace _09_19StudentsQuery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MyStudent;

    class StudentsQuery
    {
        static void Main()
        {
            //Create a List<Student> with sample students.
            List<Student> students = new List<Student>();
            students.Add(new Student() { FirstName = "Gosho", LastName = "Ivanov", Age = 18, FN = "M2360635", GroupNumber = 2, Tel = "029841184", Email = "gosho@abv.bg", Marks = new List<double> { 2, 3, 2, 5, 5 } });
            students.Add(new Student() { FirstName = "Angel", LastName = "Georgiev", Age = 21, FN = "M2360665", GroupNumber = 1, Tel = "059841184", Email = "angel@gmail.com", Marks = new List<double> { 2, 3, 5, 5, 5} });
            students.Add(new Student() { FirstName = "Iva", LastName = "Petrova", Age = 22, FN = "M2360835", GroupNumber = 1, Tel = "059661184", Email = "i.pterova@abv.bg", Marks = new List<double> { 2, 3, 5, 5, 5, 6 } });
            students.Add(new Student() { FirstName = "Galq", LastName = "Alexandrova", Age = 28, FN = "M2360875", GroupNumber = 3, Tel = "036941110", Email = "galka@gmail.com", Marks = new List<double> { 2, 3, 2, 5, 5, 6 } });
            students.Add(new Student() { FirstName = "Anna", LastName = "Galeva", Age = 23, FN = "M2360836", GroupNumber = 2, Tel = "059841124", Email = "ann@gmail.com", Marks = new List<double> { 2, 3, 5, 5, 5, 6 } });
            students.Add(new Student() { FirstName = "Vasko", LastName = "Vasilev", Age = 17, FN = "M2360638", GroupNumber = 3, Tel = "025551184", Email = "doublev@gmail.com", Marks = new List<double> { 2, 3, 5, 5, 5 } });
            students.Add(new Student() { FirstName = "Pesho", LastName = "Iliev", Age = 28, FN = "M2860935", GroupNumber = 3, Tel = "029666184", Email = "p.iliev@abv.bg", Marks = new List<double> { 2, 3, 5, 5, 5, 6 } });
            students.Add(new Student() { FirstName = "Dragan", LastName = "Cankov", Age = 30, FN = "M2360615", GroupNumber = 2, Tel = "027748884", Email = "d.c.@abv.bg", Marks = new List<double> { 6, 3, 5, 6, 6  } });
            students.Add(new Student() { FirstName = "Asen", LastName = "Gamalov", Age = 24, FN = "M2360712", GroupNumber = 3, Tel = "089899984", Email = "as@gmail.com", Marks = new List<double> { 2, 3, 5, 5, 5, 5 } });
            students.Add(new Student() { FirstName = "Balge", LastName = "Petrov", Age = 29, FN = "M2331015", GroupNumber = 3, Tel = "072841122", Email = "b.petrov@abv.bg", Marks = new List<double> { 2, 3, 5, 5, 5, 3 } });
            students.Add(new Student() { FirstName = "Dancho", LastName = "Jordanov", Age = 20, FN = "M2461235", GroupNumber = 3, Tel = "079991133", Email = "djordanov@gmail.com", Marks = new List<double> { 4, 6, 6, 5, 5, 6 } });
            //Select only the students that are from group number 2.
            var sts1 = from student in students where student.GroupNumber == 2 orderby student.FirstName select student;
            PrintStudents(sts1.ToList<Student>());
            //Implement the previous using the same query expressed with extension methods.
            var sts2 = students
                .Where(x => x.GroupNumber == 2)
                .OrderBy(x => x.FirstName)
                .ToList();
            Console.WriteLine();
            PrintStudents(sts2);
            //Extract all students that have email in abv.bg
            var sts3 = from student in students where student.Email.Contains("abv.bg") orderby student.LastName orderby student.FirstName select student;
            Console.WriteLine();
            PrintStudents(sts3.ToList());
            //Extract all students with phones in Sofia.
            var sts4 = from student in students
                       where student.Tel.StartsWith("02")
                       orderby student.LastName
                       orderby student.FirstName
                       select student;
            Console.WriteLine();
            PrintStudents(sts4.ToList());
            //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            var sts5 = from student in students
                       where student.Marks.Contains(6)
                       orderby student.LastName
                       orderby student.FirstName
                       select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };
            Console.WriteLine();
            foreach (var student in sts5)
            {
                Console.WriteLine(student.FullName);
                foreach (var mark in student.Marks)
                {
                    Console.Write("{0} ", mark);
                }
                Console.WriteLine();
            }
            //Write down a similar program that extracts the students with exactly two marks "2".
            //Use extension methods.
            var sts6 = students
                .Where(s => s.Marks.Count(x => x == 2) == 2)
                .Select(s => new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks })
                .OrderBy(s => s.FullName)
                .ToList();
            Console.WriteLine();
            foreach (var student in sts6)
            {
                Console.WriteLine(student.FullName);
                foreach (var mark in student.Marks)
                {
                    Console.Write("{0} ", mark);
                }
                Console.WriteLine();
            }
            //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            var sts7 = students
                .Where(s => s.FN.IndexOf("06") == 4)
                .OrderBy(s => s.FirstName)
                .ToList();
            Console.WriteLine();
            PrintStudents(sts7);
            List<Group> groups = new List<Group>();
            groups.Add(new Group() {GroupNumber = 1, DepartmentName = "Mathematics"});
            groups.Add(new Group() { GroupNumber = 2, DepartmentName = "Physics" });
            groups.Add(new Group() { GroupNumber = 3, DepartmentName = "Astronomics" });
            //Extract all students from "Mathematics" department.
            var sts8 = from student in students
                       join gr in groups on student.GroupNumber equals gr.GroupNumber
                       where gr.DepartmentName == "Mathematics"
                       select student;
            Console.WriteLine();
            Console.WriteLine("Students from \"Mathematics\" department.");
            PrintStudents(sts8.ToList());
            //Write a program to return the string with maximum length from an array of strings.
            string[] arrOfstr = { "aa", "aaa", "ababs", "xxyz", "longest string", "", string.Empty };
            var maxLenghtString = from str1 in arrOfstr
                                  orderby str1.Length
                                  select str1;
            Console.WriteLine(maxLenghtString.ToArray()[maxLenghtString.ToArray().Length - 1]);
            //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            var sts9 = from student in students
                       group student by student.GroupNumber into groupedStudents
                       orderby groupedStudents.Key
                       select groupedStudents;
            Console.WriteLine();
            Console.WriteLine("Create a program that extracts all students grouped by GroupNumber and then prints them to the console.");
            foreach (var stGroup in sts9)
            {
                Console.WriteLine("Key: {0}", stGroup.Key);
                PrintStudents(stGroup.ToList());
            }
            //Rewrite the previous using extension methods.
            var sts10 = students
                .GroupBy(s => s.GroupNumber);
            Console.WriteLine();
            Console.WriteLine("Rewrite the previous using extension methods.");
            foreach (var stGroup in sts9)
            {
                Console.WriteLine("Key: {0}", stGroup.Key);
                PrintStudents(stGroup.ToList());
            }


        }
        private static void PrintStudents(List<Student> st)
        {
            foreach (var student in st)
            {
                Console.WriteLine("{0,10} {1,-10} {2} age old. FN:{3}, \nGroup number:{4}, tel:{5}, Email:{6}",student.FirstName, student.LastName, student.Age, student.FN, student.GroupNumber, student.Tel, student.Email);
                Console.Write("Marks:");
                foreach (var mark in student.Marks)
                {
                    Console.Write("{0} ", mark);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
