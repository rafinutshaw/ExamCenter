//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class exam
    {
        public int evnt_id { get; set; }
        public int question_id { get; set; }
        public int course_id { get; set; }
        public int question_set { get; set; }
        public int ID { get; set; }
    
        public virtual course course { get; set; }
        public virtual evnt evnt { get; set; }
        public virtual question question { get; set; }
    }
}