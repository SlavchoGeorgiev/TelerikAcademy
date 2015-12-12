namespace StudentSystem.Services.Data
{
    using System.Linq;
    using System.Runtime.CompilerServices;
    using AutoMapper;
    using Contracts;
    using Models;
    using StudentSystem.Data;

    public class StudentService : IStudentService
    {
        private IRepository<Student> studentRepo;

        public StudentService(IRepository<Student> studentRepo)
        {
            this.studentRepo = studentRepo;
        }

        public int Add(string firstName, string lastName, int level)
        {
            var student = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                Level = level
            };

            this.studentRepo.Add(student);
            this.studentRepo.SaveChanges();

            return student.StudentIdentification;
        }

        public Student Get(int id)
        {
            return this.studentRepo.GetById(id);
        }

        public IQueryable<Student> Get(int page, int pageSize)
        {
            return this.studentRepo
                .All()
                .OrderBy(s => s.StudentIdentification)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public bool Update(int id, string firstName, string lastName, int level)
        {
            var student = this.studentRepo.GetById(id);

            if (student != null)
            {
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Level = level;
                this.studentRepo.Update(student);
                this.studentRepo.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int id)
        {

            var student = this.studentRepo.GetById(id);

            if (student == null)
            {
                return false;
            }

            this.studentRepo.Delete(student);
            this.studentRepo.SaveChanges();
            return true;
        }
    }
}
