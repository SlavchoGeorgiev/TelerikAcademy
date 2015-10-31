namespace StudentSystem.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Student
    {
        private ICollection<Homework> homeworks;
        private ICollection<Course> courses;

        public Student()
        {
            this.homeworks = new HashSet<Homework>();
            this.courses = new HashSet<Course>();
        }

        [Key]
        [Index(IsUnique = true)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public string Name { get; set; }
        
        public int Number { get; set; }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks;  }
            set { this.homeworks = value; }
        }
    }
}
