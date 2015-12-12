namespace Teleimot.Data
{
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    public class TeleimotDbContext : IdentityDbContext<User>, ITeleimotDbContext
    {
        public TeleimotDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<RealEstate> RealEstates { get; set; }

        public virtual IDbSet<Comment> Comments { get; set; }

        public virtual IDbSet<Rating> Ratings { get; set; }

        public static TeleimotDbContext Create()
        {
            return new TeleimotDbContext();
        }
    }
}
