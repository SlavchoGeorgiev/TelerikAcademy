namespace Teleimot.Data.Models
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class User : IdentityUser
    {
        public ICollection<RealEstate> realEstates;
        public ICollection<Comment> comments;
        public ICollection<Rating> rating;

        public User()
        {
            this.realEstates = new HashSet<RealEstate>();
            this.comments = new HashSet<Comment>();
            this.rating = new HashSet<Rating>();
        }

        public decimal Rating { get; set; }

        public virtual ICollection<Rating> RatingCollection
        {
            get { return this.rating; }
            set { this.rating = value; }
        }

        public virtual ICollection<RealEstate> RealEstates
        {
            get { return this.realEstates; }
            set { this.realEstates = value; }
        }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            return userIdentity;
        }
    }
}
