namespace Teleimot.Services.Data.Contracts
{
    using System.Linq;
    using Teleimot.Data.Models;

    public interface ICommentServices
    {
        IQueryable<Comment> GetById(int id);

        IQueryable<Comment> GetList(int realEstateId, int skip = 0, int take = 10);

        IQueryable<Comment> GetList(string username, int skip = 0, int take = 10);

        int Create(int realEstateId, string content, string userId);
    }
}
