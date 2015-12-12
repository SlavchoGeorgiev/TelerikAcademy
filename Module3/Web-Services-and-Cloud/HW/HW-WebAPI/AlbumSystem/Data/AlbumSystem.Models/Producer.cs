namespace AlbumSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Producer
    {
        private ICollection<Artist> artists;

        public Producer()
        {
            this.artists = new HashSet<Artist>();
        }

        [Key]
        public int Id { get; set; }

        [ForeignKey("ProducerPersonalInfo")]
        public int ProducerPersonalInfoId { get; set; }

        public virtual Person ProducerPersonalInfo { get; set; }

        public virtual ICollection<Artist> Artists
        {
            get { return this.artists; }
            set { this.artists = value; }
        }
    }
}
