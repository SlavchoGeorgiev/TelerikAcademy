namespace StudentSystem.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class StudentSystemDbContext : IdentityDbContext<User>, IStudentSystemDbContext
    {
        public StudentSystemDbContext()
            : base("StudentSystemConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }

        public IDbSet<Test> Tests { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public static StudentSystemDbContext Create()
        {
            return new StudentSystemDbContext();
        }
    }
}
