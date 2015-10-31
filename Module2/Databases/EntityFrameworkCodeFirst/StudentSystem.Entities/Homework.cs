namespace StudentSystem.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    public class Homework
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(2000)]
        public string Content { get; set; }

        public DateTime TimeSent { get; set; }
        
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        public int CourseId { get; set; }

        [Required]
        public virtual Course Course { get; set; }
    }
}
