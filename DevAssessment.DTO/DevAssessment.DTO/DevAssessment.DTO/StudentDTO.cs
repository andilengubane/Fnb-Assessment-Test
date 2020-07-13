using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAssessment.DTO
{
   public class Students
    {
		public int IDNumber { get; set; }
		public string firstname { get; set; }
		public string lastname { get; set; }
		public int gender { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public int ContactPreference { get; set; }
		public string PhotoPath { get; set; }
		public int department { get; set; }
		public string Error { get; set; }
	}

	public class StudentDTO
	{
		public int IDNumber { get; set; }
		public string FullName { get; set; }
		public string Surname { get; set; }
		public int GenderID { get; set; }
		public string email { get; set; }
		public string PhoneNumber { get; set; }
		public int ContactPreference { get; set; }
		public string PhotoPath { get; set; }
		public int DepartmentID { get; set; }
		public string Error { get; set; }
	
	}
}
