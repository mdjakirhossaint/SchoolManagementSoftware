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
    
    public partial class TuisionFeeTable
    {
        public int ID { get; set; }
        public int User_ID { get; set; }
        public int Class_ID { get; set; }
        public int Student_ID { get; set; }
        public int Division_ID { get; set; }
        public int Session_ID { get; set; }
        public double Amount { get; set; }
        public System.DateTime SubmissionDate { get; set; }
        public string FeesMonth { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
    
        public virtual ClassTable ClassTable { get; set; }
        public virtual DivisionTable DivisionTable { get; set; }
        public virtual SessionTable SessionTable { get; set; }
        public virtual StudentTable StudentTable { get; set; }
        public virtual UserTable UserTable { get; set; }
    }
}
