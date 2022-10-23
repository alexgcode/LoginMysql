using LoginMysql.Data;
using LoginMysql.Models;
using System.Collections.Generic;
using System.Linq;

namespace LoginMysql.Repositories.Implements
{
    public class StudentRepository : GenericRepository<StudentModel>, IStudentRepository
    {
        public StudentRepository(ApplicationContext context) : base(context)
        {
        }
        public IEnumerable<StudentModel> GetPopularStudents(int count)  //the first "count" students
        {
            return _context.alumno.OrderByDescending(s => s.edad).Take(count).ToList();
        }
    }
}
