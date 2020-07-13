using DevAssessment.Core.Interfaces;
using DevAssessment.DTO;
using System;
using System.Collections.Generic;

namespace DevAssessment.Service 
{
	public class StudentService : IStudentService
	{
		private readonly UnitOfWork _uow = new UnitOfWork();
		public StudentService() { }

		public StudentDTO GetStudentById(int id)
		{
			try
			{
				var results = _uow.StudentRepository.GetStudentById(id);
				if (results == null || results.FullName.Equals(String.Empty))
				{
					return new StudentDTO() { Error = "Record not found" };
				}
				else
					return results;
			}
			catch (Exception ex)
			{
				return new StudentDTO() { Error = "Something went wrong please try again later" };
			}
		}

		public List<StudentDTO> GetAllStudent()
		{
			try
			{
				var results = _uow.StudentRepository.GetAllStudents();
				return results;
			}
			catch (Exception ex)
			{
				ex.Message.ToString();
				return new List<StudentDTO>();
			}
		}

		public StudentDTO SaveStudent(StudentDTO studentDTO)
		{
			try
			{
				int result = _uow.StudentRepository.SaveStudent(studentDTO);
				if (result > 0){
					studentDTO.Error = "Department saved";
				}
				else {
					studentDTO.Error = "Department saving failed";
				}
				return new StudentDTO() { Error = "Something went wrong please try again later" };
			}
			catch (Exception ex)
			{
				return new StudentDTO() { Error = "Something went wrong please try again later" };
			}
		}
	}
}
