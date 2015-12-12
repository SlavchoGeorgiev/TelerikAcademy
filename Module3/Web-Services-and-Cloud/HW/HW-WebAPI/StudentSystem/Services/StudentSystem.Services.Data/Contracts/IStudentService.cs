namespace StudentSystem.Services.Data.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public interface IStudentService
    {
        int Add(string firstName, string lastName, int level);

        Student Get(int id);

        IQueryable<Student> Get(int page, int pageSize);

        bool Update(int id, string firstName, string lastName, int level);

        bool Delete(int id);
    }
}
