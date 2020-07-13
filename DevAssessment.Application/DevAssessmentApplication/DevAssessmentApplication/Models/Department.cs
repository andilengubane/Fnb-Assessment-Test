using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevAssessmentApplication.Models
{
	public class Department
	{
		public int DepartmentID { get; set; }
		public string Name { get; set; }
		public DateTime DateLogged { get; set; }
	}
}