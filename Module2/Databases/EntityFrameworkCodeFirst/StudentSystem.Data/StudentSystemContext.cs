namespace StudentSystem.Data
{
    using System.Data.Entity;
    using Entities;
    using StudentSystem.Data.Migrations;

    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext() 
            : base("StudentsSystemDB")
        {
            // Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<StudentSystemContext>());
        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<Homework> Homework { get; set; }

        public virtual IDbSet<Material> Materials { get; set; }
    }
}
