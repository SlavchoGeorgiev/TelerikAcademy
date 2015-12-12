namespace Teleimot.Web.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using System.Web.Management;
    using AutoMapper.QueryableExtensions;
    using Infrastructure.Validation;
    using Microsoft.AspNet.Identity;
    using Models.Users;
    using Services.Data.Contracts;

    public class UsersController : ApiController
    {
        private IUsersServices usersServices;

        public UsersController(IUsersServices usersServices)
        {
            this.usersServices = usersServices;
        }

        public IHttpActionResult Get(string id)
        {
            var username = id;

            var response = this.usersServices.GetByUsername(username)
                .ProjectTo<UserDetailsResponseModel>()
                .FirstOrDefault();

            if (response == null)
            {
                return this.NotFound();
            }

            return this.Ok(response);
        }

        [HttpPut]
        [Route("api/Users/Rate")]
        [Authorize]
        [ValidateModel]
        public IHttpActionResult Rate(RateUserRequestModel model)
        {
            if (!this.usersServices.IsUserExist(model.UserId))
            {
                return this.NotFound();
            }

            if (this.User.Identity.GetUserId() == model.UserId)
            {
                return BadRequest("You cannot rate your self!");
            }

            this.usersServices.Rate(model.UserId, model.Value);
            this.usersServices.UpdateRating(model.UserId);

            return this.Ok();
        }
    }
}
