//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CCTT
{
    using System;
    using System.Collections.Generic;
    
    public partial class semster_student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public semster_student()
        {
            this.semster_student_main_cours = new HashSet<semster_student_main_cours>();
        }
    
        public int id { get; set; }
        public Nullable<int> year_id { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<int> department_id { get; set; }
        public Nullable<decimal> gpa { get; set; }
        public Nullable<decimal> rate_semster { get; set; }
        public Nullable<int> stateGrade { get; set; }
        public Nullable<int> unit { get; set; }
        public Nullable<int> sem_id { get; set; }
    
        public virtual department department { get; set; }
        public virtual Year Year { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<semster_student_main_cours> semster_student_main_cours { get; set; }
        public virtual student student { get; set; }
        public virtual Semester Semester { get; set; }
    }
}
