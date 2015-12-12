namespace AlbumSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        private ICollection<Person> persons;

        public Country()
        {
            this.persons = new HashSet<Person>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string Name { get; set; }

        public virtual ICollection<Person> Persons
        {
            get { return this.persons; }
            set { this.persons = value; }
        }
    }
}
