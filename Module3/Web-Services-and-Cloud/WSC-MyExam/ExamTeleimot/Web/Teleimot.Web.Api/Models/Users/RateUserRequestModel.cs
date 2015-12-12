namespace Teleimot.Web.Api.Models.Users
{
    using System.ComponentModel.DataAnnotations;

    public class RateUserRequestModel
    {
        [Required]
        public string UserId { get; set; }

        [Range(1, 5)]
        public int Value { get; set; }
    }
}
