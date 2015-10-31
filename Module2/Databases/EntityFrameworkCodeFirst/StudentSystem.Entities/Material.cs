namespace StudentSystem.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Material
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        [MinLength(2)]
        public string Name { get; set; }

        [MaxLength(3000)]
        public string Content { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
