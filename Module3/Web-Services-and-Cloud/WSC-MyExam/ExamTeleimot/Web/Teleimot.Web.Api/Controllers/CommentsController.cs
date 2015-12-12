namespace Teleimot.Web.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using AutoMapper.QueryableExtensions;
    using Infrastructure.Validation;
    using Microsoft.AspNet.Identity;
    using Models.Comments;
    using Services.Data.Contracts;

    public class CommentsController : ApiController
    {
        private IRealEstatesServices realEstatesServices;
        private ICommentServices commentServices;

        public CommentsController(IRealEstatesServices realEstatesServices, ICommentServices commentServices)
        {
            this.realEstatesServices = realEstatesServices;
            this.commentServices = commentServices;
        }

        [Authorize]
        public IHttpActionResult Get(int id, int skip = 0, int take = 10)
        {
            if (realEstatesServices.GetById(id).FirstOrDefault() == null)
            {
                return this.NotFound();
            }

            if (skip < 0)
            {
                return this.BadRequest("Skip must be positive number");
            }

            if (take < 0 || take > 100)
            {
                return this.BadRequest("Take must be in interval [0, 100]!");
            }

            var response = this.commentServices.GetList(id, skip, take)
                .ProjectTo<CommentResponseModel>()
                .ToList();

            if (response.Count == 0)
            {
                return this.NotFound();
            }

            return this.Ok(response);
        }

        [Authorize]
        [Route("api/Comments/ByUser/{id}")]
        [HttpGet]
        public IHttpActionResult ByUser(string id, int skip = 0, int take = 10)
        {
            //Please do not use "." in user name!
            var username = id; 

            if (username == null)
            {
                return this.BadRequest("Pleae provide user name in URL.");
            }

            if (skip < 0)
            {
                return this.BadRequest("Skip must be positive number");
            }

            if (take < 0 || take > 100)
            {
                return this.BadRequest("Take must be in interval [0, 100]!");
            }

            var response = this.commentServices.GetList(username , skip, take)
                .ProjectTo<CommentResponseModel>()
                .ToList();

            if (response.Count == 0)
            {
                return this.NotFound();
            }

            return this.Ok(response);
        }

        [Authorize]
        [ValidateModel]
        public IHttpActionResult Post(CreateCommentRequestModel model)
        {
            if (realEstatesServices.GetById(model.RealEstateId).FirstOrDefault() == null)
            {
                return this.NotFound();
            }

            int commentId = this.commentServices.Create(
                model.RealEstateId,
                model.Content,
                this.User.Identity.GetUserId());

            var response = this.commentServices.GetById(commentId)
                .ProjectTo<CommentResponseModel>()
                .FirstOrDefault();

            return this.Created("", response);
        }
    }
}
