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
    
    public partial class extra_Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public extra_Course()
        {
            this.Course_inStudent = new HashSet<Course_inStudent>();
        }
    
        public string course_code { get; set; }
        public string course_name { get; set; }
        public string course_information { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> trainer_id { get; set; }
        public Nullable<int> max_student_count { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<int> hours { get; set; }
        public string days { get; set; }
        public Nullable<int> course_status { get; set; }
        public int id { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public string daysString { get; set; }
    
        public virtual Trainer Trainer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_inStudent> Course_inStudent { get; set; }
    }
}
