namespace Teleimot.Web.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using AutoMapper.QueryableExtensions;
    using Data.Models;
    using Infrastructure.Validation;
    using Microsoft.AspNet.Identity;
    using Models.RealEstates;
    using Services.Data.Contracts;

    public class RealEstatesController : ApiController
    {
        /*
        Please register with username like in example:
        "Username=ivaylokenov&Email=ivaylo@kenov.com&Password=123456q&ConfirmPassword=123456q"

        and

        Login with this username from registration NOT with email name:
        Username=ivaylokenov&Password=123456q&grant_type=password
        */
        private IRealEstatesServices realEstatesServices;

        public RealEstatesController(IRealEstatesServices realEstatesServices)
        {
            this.realEstatesServices = realEstatesServices;
        }

        public IHttpActionResult Get(int id)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                var response = this.realEstatesServices.GetById(id)
                    .ProjectTo<PublicDetailsRealEstateResponseModel>()
                    .FirstOrDefault();

                if (response == null)
                {
                    return this.NotFound();
                }

                return this.Ok(response);
            }
            else
            {
                var response = this.realEstatesServices.GetById(id)
                        .ProjectTo<PrivateDetailsRealEstateResponseModel>()
                        .FirstOrDefault();

                if (response == null)
                {
                    return this.NotFound();
                }

                return this.Ok(response);
            }

        }

        public IHttpActionResult Get(int skip = 0, int take = 10)
        {
            if (skip < 0)
            {
                return this.BadRequest("Skip must be positive number");
            }

            if (take < 0 || take > 100)
            {
                return this.BadRequest("Take must be in interval [0, 100]!");
            }

            var response = this.realEstatesServices.GetList(skip, take)
                .ProjectTo<BaseRealEstateResponseModel>()
                .ToList();

            if (response.Count == 0)
            {
                return this.NotFound();
            }

            return this.Ok(response);
        }

        [Authorize]
        [ValidateModel]
        public IHttpActionResult Post(CreateRealEstateRequestModel model)
        {
            if (model.SellingPrice == null && model.RentingPrice == null)
            {
                return this.BadRequest("Real estate can be published only for renting, only for selling or for both, but not without any of the two options!");
            }

            int realEstateId = this.realEstatesServices.Create(
                model.Title,
                model.Description,
                model.Address,
                model.Contact,
                model.ConstructionYear,
                model.SellingPrice,
                model.RentingPrice,
                (RealEstateType)model.Type,
                this.User.Identity.GetUserId());

            var response = realEstatesServices.GetById(realEstateId)
                .ProjectTo<BaseRealEstateResponseModel>()
                .FirstOrDefault();

            return this.Created(string.Format("api/RealEstates/{0}", realEstateId), response);
        }
    }
}
