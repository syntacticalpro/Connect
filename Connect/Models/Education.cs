//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Connect.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Education
    {
        public long EducationId { get; set; }
        public string School { get; set; }
        public int DegreeType { get; set; }
        public int EduFrom { get; set; }
        public int EduTo { get; set; }
        public long UserId { get; set; }
        public string Course { get; set; }
    
        public virtual Degree Degree { get; set; }
        public virtual User User { get; set; }
    }
}
