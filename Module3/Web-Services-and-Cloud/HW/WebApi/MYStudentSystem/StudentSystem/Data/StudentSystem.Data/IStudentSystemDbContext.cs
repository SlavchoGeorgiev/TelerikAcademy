namespace StudentSystem.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Models;

    public interface IStudentSystemDbContext
    {
        IDbSet<Course> Courses { get; set; }

        IDbSet<Student> Students { get; set; }

        IDbSet<Homework> Homeworks { get; set; }

        IDbSet<Test> Tests { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
