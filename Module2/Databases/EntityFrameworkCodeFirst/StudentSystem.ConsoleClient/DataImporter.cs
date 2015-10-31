namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Linq;

    using Data;
    using Entities;

    public class DataImporter
    {
        public void ImportStudents(int numberOfStudents)
        {
            Console.Write("Importing Students");
            var db = new StudentSystemContext();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var student = new Student()
                {
                    Name = RandomGenerator.GetString(2, 50),
                    Number = RandomGenerator.GetInt(7000000, 8000000)
                };

                db.Students.Add(student);

                if (i % 50 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                    db.Dispose();
                    db = new StudentSystemContext();
                }
            }

            db.SaveChanges();
            Console.WriteLine(" Completed!");
        }

        public void ImportCourses(int numberOfCourses)
        {
            var db = new StudentSystemContext();
            Console.Write("Importing Courses");

            for (int i = 0; i < numberOfCourses; i++)
            {
                var course = new Course()
                {
                    Name = RandomGenerator.GetString(10, 100),
                    Description = RandomGenerator.GetString(100, 1000)
                };

                db.Courses.Add(course);

                if (i % 50 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                    db.Dispose();
                    db = new StudentSystemContext();
                }
            }

            db.SaveChanges();
            Console.WriteLine(" Completed!");
        }

        public void ImportMaterials(int averageMaterialsInCourse)
        {
            var db = new StudentSystemContext();
            Console.Write("Importing Materials");

            var courseIds = db.Courses.Select(c => c.Id).ToList();
            var counter = 0;
            foreach (var id in courseIds)
            {
                var numberOfMaterialsForCurrentCourse = RandomGenerator
                    .GetInt(averageMaterialsInCourse - 5, averageMaterialsInCourse + 5);

                for (int j = 0; j < numberOfMaterialsForCurrentCourse; j++)
                {
                    var material = new Material()
                    {
                        Name = RandomGenerator.GetString(10, 80),
                        Content = RandomGenerator.GetString(100, 3000),
                        CourseId = id
                    };

                    db.Materials.Add(material);
                    counter++;
                }

                if (counter > 100)
                {
                    Console.Write(".");
                    db.SaveChanges();
                    db.Dispose();
                    db = new StudentSystemContext();
                    counter = 0;
                }
            }

            db.SaveChanges();
            Console.WriteLine(" Completed!");
        }

        public void StudentCoursesConnect(int averageCoursesPerStudent)
        {
            Console.WriteLine("Create students - courses relations.");
            var db = new StudentSystemContext();
            var students = db.Students.Select(s => s).ToList();
            var courses = db.Courses.Select(c => c).ToList();
            var coursesCount = courses.Count();

            foreach (var student in students)
            {
                var numberOfCoursesForCurrentStudent = RandomGenerator.GetInt(averageCoursesPerStudent - 5, averageCoursesPerStudent + 5);

                for (int i = 0; i < numberOfCoursesForCurrentStudent; i++)
                {
                    student.Courses.Add(courses[RandomGenerator.GetInt(0, coursesCount - 1)]);
                }

                Console.Write(".");
            }

            db.SaveChanges();
            Console.WriteLine("Student Courses relation process completed.");
        }

        public void ImportHomeWorks(int numberOfHomeworks)
        {
            Console.Write("Importing Homework");
            var db = new StudentSystemContext();
            var studentIds = db.Students.Select(s => s.Id).ToList();
            var studentsCount = studentIds.Count();
            var counter = 0;

            while (numberOfHomeworks > 0)
            {
                var student = db.Students.Find(studentIds[RandomGenerator.GetInt(0, studentsCount - 1)]);
                if (student != null && student.Courses.Count != 0)
                {
                    var homework = new Homework()
                    {
                        Content = RandomGenerator.GetString(20, 1000),
                        TimeSent = RandomGenerator.GetDate(new DateTime(2014, RandomGenerator.GetInt(1, 12), RandomGenerator.GetInt(1, 28)), DateTime.Now)
                    };

                    student.Homeworks.Add(homework);
                    var studentCoursesIds = student.Courses.Select(c => c.Id).ToList();

                    db.Courses.Find(studentCoursesIds[RandomGenerator.GetInt(0, studentCoursesIds.Count - 1)]).Homeworks.Add(homework);
                    counter++;
                    numberOfHomeworks--;
                }

                if (counter > 100)
                {
                    db.SaveChanges();
                    db.Dispose();
                    db = new StudentSystemContext();
                    Console.Write(".");
                    counter = 0;
                }
            }

            db.SaveChanges();
            Console.WriteLine(" Completed!");
        }
    }
}
