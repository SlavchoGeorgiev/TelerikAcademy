namespace StudentSystem.Api.Models.Student
{
    using System.ComponentModel.DataAnnotations;
    using Infrastructure.Mapping;
    using StudentSystem.Models;

    public class SaveStudentdRequestModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        public int Level { get; set; }
    }
}
