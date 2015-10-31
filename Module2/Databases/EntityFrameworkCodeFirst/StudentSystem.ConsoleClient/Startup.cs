namespace StudentSystem.ConsoleClient
{
    public class Startup
    {
        public static void Main()
        {
            var importer = new DataImporter();

            importer.ImportCourses(100);
            importer.ImportStudents(1000);
            importer.ImportMaterials(10);
            importer.StudentCoursesConnect(15);
            importer.ImportHomeWorks(500);
        }
    }
}