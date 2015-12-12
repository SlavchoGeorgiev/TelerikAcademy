namespace StudentSystem.Api
{
    using System.Data.Entity;

    using Data;
    using Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
            StudentSystemDbContext.Create().Database.Initialize(true);
        }
    }
}
