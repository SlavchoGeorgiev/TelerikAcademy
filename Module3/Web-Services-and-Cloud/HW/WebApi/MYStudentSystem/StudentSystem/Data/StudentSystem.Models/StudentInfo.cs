namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [ComplexType]
    public class StudentInfo
    {
        [Column("Email")]
        [MaxLength(100)]
        public string Email { get; set; }

        [Column("Address")]
        [MaxLength(300)]
        public string Address { get; set; }
    }
}
