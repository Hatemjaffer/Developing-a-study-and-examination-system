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
    
    public partial class main_course_rel_semster
    {
        public int id { get; set; }
        public Nullable<int> department_id { get; set; }
        public Nullable<int> main_cours_id { get; set; }
        public Nullable<int> semster_id { get; set; }
    
        public virtual department department { get; set; }
        public virtual main_course main_course { get; set; }
        public virtual Semester Semester { get; set; }
    }
}
