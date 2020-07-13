using System.Web.Http;
using DevAssessment.Service;
using DevAssessment.DTO;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace DevAssessmentApplication.Controllers
{
	public class StudentController : ApiController
    {
		private readonly IStudentService _studentService;
		public StudentController()
		{
			_studentService = new StudentService();
		}
		
		[HttpGet]
		public IHttpActionResult GetAllStudents()
		{
			var results = _studentService.GetAllStudent();
			if (results != null)
			{
				return Ok(results);
			}
			return BadRequest("Something went wrong");
		}
	
		[HttpPost]
		public IHttpActionResult SaveStudent([FromBody] Students student)
		{
			StudentDTO studentDTO = new StudentDTO();
			studentDTO.FullName = student.firstname;
			studentDTO.Surname = student.lastname;
			studentDTO.email = student.Email;
			studentDTO.GenderID = student.gender;
			studentDTO.ContactPreference = student.ContactPreference;
			studentDTO.DepartmentID = student.department;
			studentDTO.PhoneNumber = student.PhoneNumber;
			studentDTO.PhotoPath = "image/image.png";

			var results = _studentService.SaveStudent(studentDTO);
			if (results != null)
			{
				return Ok(results);
			}
			return BadRequest("Something went wrong");
		}
	}
}
