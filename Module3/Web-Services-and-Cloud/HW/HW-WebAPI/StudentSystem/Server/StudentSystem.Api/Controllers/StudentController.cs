namespace StudentSystem.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using AutoMapper;
    using Models.Student;
    using Services.Data.Contracts;
    using AutoMapper.QueryableExtensions;

    public class StudentController : ApiController
    {
        private IStudentService student;

        public StudentController(IStudentService student)
        {
            this.student = student;
        }

        public IHttpActionResult Get()
        {
            var result = this.student
                .Get(1, 10)
                .ProjectTo<StudentResponseModel>()
                .ToList();


            if (result.Count <= 0)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            var result = Mapper.Map<StudentResponseModel>(student.Get(id));

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        public IHttpActionResult Post(SaveStudentdRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest("Student model is not valid!");
            }

            var currentStudentId = this.student.Add(
                model.FirstName,
                model.LastName,
                model.Level);

            return this.Ok(currentStudentId);
        }

        public IHttpActionResult Put(int id, SaveStudentdRequestModel model)
        {
            if (this.ModelState.IsValid)
            {
                if (this.student.Update(
                    id,
                    model.FirstName,
                    model.LastName,
                    model.Level
                    ))
                {
                    return this.Ok();
                }
                else
                {
                    return this.NotFound();
                }
            }

            return this.BadRequest("Student update model is not valid!");
        }

        public IHttpActionResult Delete(int id)
        {
            if (this.student.Delete(id))
            {
                return this.Ok();
            }

            return this.NotFound();
        }
    }
}
