//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevAssessment.EntityFramework.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContactPreferance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContactPreferance()
        {
            this.Students = new HashSet<Student>();
        }
    
        public int ContactPreferance1 { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateLogged { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
