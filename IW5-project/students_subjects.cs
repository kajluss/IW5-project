//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IW5_project
{
    using System;
    using System.Collections.Generic;
    
    public partial class students_subjects
    {
        public int Id { get; set; }
        public int student_id { get; set; }
        public int subject_id { get; set; }
    
        public virtual student student { get; set; }
        public virtual subject subject { get; set; }
    }
}
