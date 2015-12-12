namespace StudentSystem.Api.Models.Student
{
    using Infrastructure.Mapping;
    using StudentSystem.Models;

    public class StudentResponseModel : IMapFrom<Student>
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int Level { get; set; }
    }
}
