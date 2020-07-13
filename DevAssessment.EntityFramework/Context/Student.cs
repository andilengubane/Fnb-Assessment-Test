
using System;
using System.Collections.Generic;
namespace DevAssessment.EntityFramework.Context
{
    public partial class Student
    {
        public int IDNumber { get; set; }
        public string FullName { get; set; }
        public string Surname { get; set; }
        public Nullable<int> GenderID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> ContactPreference { get; set; }
        public string PhotoPath { get; set; }
        public Nullable<int> DepartmentID { get; set; }
    
        public virtual ContactPreferance ContactPreferance { get; set; }
        public virtual Department Department { get; set; }
        public virtual Gender Gender { get; set; }
    }
}
