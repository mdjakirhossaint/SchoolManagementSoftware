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
    
    public partial class SessionTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SessionTable()
        {
            this.ApplicationForInstallmentTables = new HashSet<ApplicationForInstallmentTable>();
            this.ClassRoutinelTables = new HashSet<ClassRoutinelTable>();
            this.EstablishmentFeelTables = new HashSet<EstablishmentFeelTable>();
            this.ExamFeelTables = new HashSet<ExamFeelTable>();
            this.ExamMarksTables = new HashSet<ExamMarksTable>();
            this.ExamTables = new HashSet<ExamTable>();
            this.StudentAssignmentTables = new HashSet<StudentAssignmentTable>();
            this.StudentAttendanceTables = new HashSet<StudentAttendanceTable>();
            this.StudentDailyWorklTables = new HashSet<StudentDailyWorklTable>();
            this.StudentTables = new HashSet<StudentTable>();
            this.StudyTourFeelTables = new HashSet<StudyTourFeelTable>();
            this.SubjectTables = new HashSet<SubjectTable>();
            this.TeacherFeedbackTables = new HashSet<TeacherFeedbackTable>();
            this.TransportationFeelTables = new HashSet<TransportationFeelTable>();
            this.TuisionFeeTables = new HashSet<TuisionFeeTable>();
        }
    
        public int ID { get; set; }
        public int User_ID { get; set; }
        public string Name { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationForInstallmentTable> ApplicationForInstallmentTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassRoutinelTable> ClassRoutinelTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstablishmentFeelTable> EstablishmentFeelTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamFeelTable> ExamFeelTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamMarksTable> ExamMarksTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamTable> ExamTables { get; set; }
        public virtual UserTable UserTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentAssignmentTable> StudentAssignmentTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentAttendanceTable> StudentAttendanceTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentDailyWorklTable> StudentDailyWorklTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentTable> StudentTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudyTourFeelTable> StudyTourFeelTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubjectTable> SubjectTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherFeedbackTable> TeacherFeedbackTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportationFeelTable> TransportationFeelTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TuisionFeeTable> TuisionFeeTables { get; set; }
    }
}
