﻿namespace Teleimot.Web.Api.Models.RealEstates
{
    using Data.Models;
    using Infrastructure.Mappings;

    public class BaseRealEstateResponseModel : IMapFrom<RealEstate>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int? SellingPrice { get; set; }

        public int? RentingPrice { get; set; }

        public bool CanBeSold { get; set; }

        public bool CanBeRented { get; set; }
    }
}
