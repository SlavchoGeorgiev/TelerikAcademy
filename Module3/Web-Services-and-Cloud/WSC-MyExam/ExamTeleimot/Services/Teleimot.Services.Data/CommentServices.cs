namespace Teleimot.Services.Data
{
    using System.Linq;
    using Contracts;
    using Teleimot.Data.Models;
    using Teleimot.Data.Repositories;

    public class CommentServices : ICommentServices
    {
        private IRepository<Comment> commentRepository;

        public CommentServices(IRepository<Comment> commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        public IQueryable<Comment> GetById(int id)
        {
            return this.commentRepository
                .All()
                .Where(c => c.Id == id);
        }

        public IQueryable<Comment> GetList(int realEstateId, int skip = 0, int take = 10)
        {
            return this.commentRepository
                .All()
                .Where(c => c.RealEstateId == realEstateId)
                .OrderBy(c => c.CreatedOn)
                .Skip(skip)
                .Take(take);
        }

        public IQueryable<Comment> GetList(string username, int skip = 0, int take = 10)
        {
            return this.commentRepository
                .All()
                .Where(c => c.User.UserName.StartsWith(username))
                .OrderBy(c => c.CreatedOn)
                .Skip(skip)
                .Take(take);
        }

        public int Create(int realEstateId, string content, string userId)
        {
            var newComment = new Comment()
            {
                Content = content,
                RealEstateId = realEstateId,
                UserId = userId
            };

            this.commentRepository.Add(newComment);
            this.commentRepository.SaveChanges();

            return newComment.Id;
        }
    }
}
