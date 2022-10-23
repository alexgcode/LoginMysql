using LoginMysql.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginMysql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult GetPopularStudents([FromQuery]int count)
        {
            var popularStudents = _unitOfWork.Students.GetPopularStudents(count);
            return Ok(popularStudents);
        }
    }
}
