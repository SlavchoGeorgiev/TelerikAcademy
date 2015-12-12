namespace Teleimot.Web.Api.Models.Comments
{
    using System.ComponentModel.DataAnnotations;

    public class CreateCommentRequestModel
    {
        public int RealEstateId { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string Content { get; set; }
    }
}
