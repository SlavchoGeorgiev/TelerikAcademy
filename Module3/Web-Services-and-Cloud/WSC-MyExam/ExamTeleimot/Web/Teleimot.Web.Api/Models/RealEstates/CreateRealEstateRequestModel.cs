namespace Teleimot.Web.Api.Models.RealEstates
{
    using System.ComponentModel.DataAnnotations;

    public class CreateRealEstateRequestModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        [MaxLength(500)]
        public string Address { get; set; }

        [Required]
        [MaxLength(500)]
        public string Contact { get; set; }

        [Range(1800, 10000)]
        public int ConstructionYear { get; set; }

        public int? SellingPrice { get; set; }

        public int? RentingPrice { get; set; }

        public int Type { get; set; }
    }
}
