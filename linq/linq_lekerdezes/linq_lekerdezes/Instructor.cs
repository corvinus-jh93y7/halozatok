//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace linq_lekerdezes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instructor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instructor()
        {
            this.Lessons = new HashSet<Lesson>();
        }
    
        public int InstructorSK { get; set; }
        public string Salutation { get; set; }
        public string Name { get; set; }
        public Nullable<byte> StatusFK { get; set; }
        public string EmployementFK { get; set; }
    
        public virtual Employement Employement { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
