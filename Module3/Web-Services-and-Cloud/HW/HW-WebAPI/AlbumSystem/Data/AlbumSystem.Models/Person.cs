namespace AlbumSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int? CountryId { get; set; }

        public Country Country { get; set; }
        
        //public int? ProducerId { get; set; }

        //public Producer Producer { get; set; }

        //public int? ArtistId { get; set; }

        //public Artist Artist { get; set; }
    }
}
