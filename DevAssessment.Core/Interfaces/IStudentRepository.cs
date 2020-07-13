using DevAssessment.DTO;
using DevAssessment.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DevAssessment.Core.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
		int SaveStudent(StudentDTO StudentDTO);
		List<StudentDTO> GetAllStudent(Expression<Func<Student, bool>> predicate);
		StudentDTO GetStudentById(int id);
		List<StudentDTO> GetAllStudents();
	}
}
