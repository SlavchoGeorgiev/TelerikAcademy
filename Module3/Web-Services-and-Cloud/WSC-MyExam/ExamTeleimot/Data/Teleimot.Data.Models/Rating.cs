namespace Teleimot.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Rating
    {
        [Key]
        public int Id { get; set; }

        [Range(1, 5)]
        public int Value { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
