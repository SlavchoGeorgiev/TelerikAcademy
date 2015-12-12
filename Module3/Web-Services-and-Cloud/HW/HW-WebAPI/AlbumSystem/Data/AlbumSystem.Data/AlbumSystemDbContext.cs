namespace AlbumSystem.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class AlbumSystemDbContext : IdentityDbContext<User>, IAlbumSystemDbContext
    {
        public AlbumSystemDbContext()
            : base("AlbumSystemConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Person> Persons { get; set; }

        public IDbSet<Artist> Artists { get; set; }

        public IDbSet<Producer> Producers { get; set; }

        public IDbSet<Song> Songs { get; set; }

        public IDbSet<Album> Albums { get; set; }

        public IDbSet<Country> Countries { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public static AlbumSystemDbContext Create()
        {
            return new AlbumSystemDbContext();
        }
    }
}
