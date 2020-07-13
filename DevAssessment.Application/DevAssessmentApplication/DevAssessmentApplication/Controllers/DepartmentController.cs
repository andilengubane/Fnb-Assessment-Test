using DevAssessment.Service;
using System.Web.Http;

namespace DevAssessmentApplication.Controllers
{
    public class DepartmentController : ApiController
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController()
        {
            _departmentService = new DepartmentService();
        }
      
        [HttpGet]
        public IHttpActionResult GetAllDepartment()
        {
            var results =_departmentService.GetAllDepartment();

            if (results != null)
            {
                return Ok(results);
            }
            return BadRequest("Something went wrong");
        }
    }
}
