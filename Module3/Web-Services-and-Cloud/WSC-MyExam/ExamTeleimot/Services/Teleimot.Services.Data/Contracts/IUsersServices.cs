namespace Teleimot.Services.Data.Contracts
{
    using System.Linq;
    using Teleimot.Data.Models;

    public interface IUsersServices
    {
        IQueryable<User> GetByUsername(string username);

        bool IsUserExist(string id);

        void Rate(string id, int value);

        void UpdateRating(string userId);
    }
}
