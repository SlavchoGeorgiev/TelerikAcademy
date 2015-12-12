namespace Teleimot.Data
{
    using Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public interface ITeleimotDbContext
    {
        IDbSet<User> Users { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        
        IDbSet<RealEstate> RealEstates { get; set; }

        IDbSet<Comment> Comments { get; set; }

        IDbSet<Rating> Ratings { get; set; }

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();

        void Dispose();
    }
}
