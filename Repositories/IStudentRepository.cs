using LoginMysql.Models;
using System.Collections.Generic;

namespace LoginMysql.Repositories
{
    public interface IStudentRepository : IGenericRepository<StudentModel>
    {
        IEnumerable<StudentModel> GetPopularStudents(int count);
    }
}
