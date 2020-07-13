using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DevAssessment.Core.Interfaces;
using DevAssessment.DTO;
using DevAssessment.EntityFramework.Context;
using DevAssessment.Core.Mapper;


namespace DevAssessment.Core.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private DevAssessmentEntities _context;

		public StudentRepository(DevAssessmentEntities context) : base(context)
        {
			_context = context;
			DtoMapping.Map();
		}

		public List<StudentDTO> GetAllStudent(Expression<Func<Student, bool>> predicate)
		{
			var results = Find(predicate);
			return AutoMapper.Mapper.Map<List<StudentDTO>>(results);
		}

		public List<StudentDTO> GetAllStudents()
		{
			var results = GetAll(); ;
			return AutoMapper.Mapper.Map<List<StudentDTO>>(results);
		}

		public StudentDTO GetStudentById(int id)
		{
			var students = Get(id);
			return AutoMapper.Mapper.Map<StudentDTO>(students);
		}
		public int SaveStudent(StudentDTO StudentDTO)
		{
			Student n = new Student();
			n.ContactPreferance = null;
			n.Department = null;
			n.Gender = null;
			n.ContactPreference = StudentDTO.ContactPreference;
			n.FullName = StudentDTO.FullName;
			n.Surname = StudentDTO.Surname;
			n.Email = StudentDTO.email;
			n.GenderID = StudentDTO.GenderID;
			n.DepartmentID = StudentDTO.DepartmentID;
			n.PhoneNumber = StudentDTO.PhoneNumber;
			n.PhotoPath = StudentDTO.PhotoPath;

			var student = AutoMapper.Mapper.Map<Student>(n);
			return Add(student);
		}
	}
}