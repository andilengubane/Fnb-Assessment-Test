using System;
using DevAssessment.DTO;
using System.Collections.Generic;

namespace DevAssessment.Service
{
	public interface IStudentService
	{
		StudentDTO SaveStudent(StudentDTO StudentDTO);
		StudentDTO GetStudentById(int id);
		List<StudentDTO> GetAllStudent();
	}
}
