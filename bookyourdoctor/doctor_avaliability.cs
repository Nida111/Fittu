//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bookyourdoctor
{
    using System;
    using System.Collections.Generic;
    
    public partial class doctor_avaliability
    {
        public string avaliability_id { get; set; }
        public string office_id { get; set; }
        public string day_of_week { get; set; }
        public System.DateTime start_time { get; set; }
        public System.DateTime end_time { get; set; }
        public string is_avalible { get; set; }
    
        public virtual office office { get; set; }
    }
}