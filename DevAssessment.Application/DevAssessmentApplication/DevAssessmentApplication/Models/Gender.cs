using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevAssessmentApplication.Models
{
	public class Gender
	{
		public int GenderID { get; set; }
		public string Description { get; set; }
		public DateTime DateLogged { get; set; }
	}
}