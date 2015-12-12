namespace Teleimot.Services.Data
{
    using System.Linq;
    using Contracts;
    using Teleimot.Data.Models;
    using Teleimot.Data.Repositories;

    public class UsersServices : IUsersServices
    {
        private IRepository<User> usersRepository;

        public UsersServices(IRepository<User> usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public IQueryable<User> GetByUsername(string username)
        {
            return this.usersRepository
                .All()
                .Where(u => u.UserName == username);
        }

        public bool IsUserExist(string id)
        {
            return this.usersRepository
                .All()
                .Any(u => u.Id == id);
        }

        public void Rate(string id, int value)
        {
            var user = this.usersRepository
                .All()
                .FirstOrDefault(u => u.Id == id);

            user.RatingCollection.Add(new Rating()
            {
                UserId = id,
                Value = value,
            });

            usersRepository.Update(user);
            usersRepository.SaveChanges();
        }

        public void UpdateRating(string userId)
        {
            var user = this.usersRepository
                .All()
                .FirstOrDefault(u => u.Id == userId);

            user.Rating = (decimal)user.RatingCollection.Average(r => r.Value);

            usersRepository.Update(user);
            usersRepository.SaveChanges();
        }
    }
}
