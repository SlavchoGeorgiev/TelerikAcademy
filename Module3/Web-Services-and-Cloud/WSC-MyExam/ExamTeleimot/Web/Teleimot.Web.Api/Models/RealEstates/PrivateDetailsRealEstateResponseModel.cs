namespace Teleimot.Web.Api.Models.RealEstates
{
    using System;
    using System.Collections.Generic;
    using AutoMapper;
    using Comments;
    using Data.Models;
    using Infrastructure.Mappings;

    public class PrivateDetailsRealEstateResponseModel : IMapFrom<RealEstate>
    {
        public string Contact { get; set; }

        public ICollection<CommentResponseModel> Comments { get; set; }

        public DateTime CreatedOn { get; set; }

        public int ConstructionYear { get; set; }

        public string Address { get; set; }

        public RealEstateType RealEstateType { get; set; }

        public string Description { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

        public int? SellingPrice { get; set; }

        public int? RentingPrice { get; set; }

        public bool CanBeSold { get; set; }

        public bool CanBeRented { get; set; }


        //public virtual void CreateMappings(IConfiguration configuration)
        //{
        //    configuration.CreateMap<RealEstate, PublicDetailsRealEstateResponseModel>()
        //        .ForMember(re => re.RealEstateType, opts => opts.MapFrom(re => re.RealEstateType.ToString()));
        //}
    }
}
