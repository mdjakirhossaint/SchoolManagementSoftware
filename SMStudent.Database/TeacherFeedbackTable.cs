//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMStudent.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeacherFeedbackTable
    {
        public int ID { get; set; }
        public int Teacher_ID { get; set; }
        public int Student_ID { get; set; }
        public int Class_ID { get; set; }
        public int Session_ID { get; set; }
        public string Comments { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> EditTime { get; set; }
    
        public virtual ClassTable ClassTable { get; set; }
        public virtual SessionTable SessionTable { get; set; }
        public virtual StudentTable StudentTable { get; set; }
        public virtual TeacherTable TeacherTable { get; set; }
    }
}