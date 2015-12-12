namespace AlbumSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Artist
    {
        private ICollection<Song> songs;

        public Artist()
        {
            this.songs = new HashSet<Song>();
        }

        [Key]
        public int Id { get; set; }

        [ForeignKey("ArtistPersonalInfo")]
        public int ArtistPersonalInfoId { get; set; }
        
        public virtual Person ArtistPersonalInfo { get; set; }
        
        [ForeignKey("Producer")]
        public int? ProducerId { get; set; }

        public virtual Producer Producer { get; set; }

        public virtual ICollection<Song> Songs
        {
            get { return this.songs; }
            set { this.songs = value; }
        }
    }
}
