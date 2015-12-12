namespace AlbumSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Song
    {
        private ICollection<Album> albums;
        private ICollection<Artist> artist;

        public Song()
        {
            this.albums = new HashSet<Album>();
            this.artist = new HashSet<Artist>();
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int? Year { get; set; }

        public virtual ICollection<Album> Albums
        {
            get { return this.albums; }
            set { this.albums = value; }
        }
        
        public virtual ICollection<Artist> Artist
        {
            get { return this.artist; }
            set { this.artist = value; }
        }
    }
}
