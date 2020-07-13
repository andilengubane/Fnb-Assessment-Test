using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevAssessmentApplication.Models
{
	public class Student
	{
	   public int IDNumber { get; set; }
       public string FullName {get;set; }
       public string Surname { get; set; }
       public int GenderID { get; set; }
       public string Email { get; set; }
       public string PhoneNumber { get; set; }
       public int ContactPreference { get; set; }
       public string PhotoPath { get; set; }
       public int DepartmentID { get; set; }
	}
}