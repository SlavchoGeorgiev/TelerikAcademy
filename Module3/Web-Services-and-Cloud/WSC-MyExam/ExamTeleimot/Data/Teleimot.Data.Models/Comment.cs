namespace Teleimot.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Comment
    {
        public Comment()
        {
            this.CreatedOn = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public virtual User User { get; set; }

        [ForeignKey("RealEstate")]
        public int RealEstateId { get; set; }

        public virtual RealEstate RealEstate { get; set; }
    }
}
