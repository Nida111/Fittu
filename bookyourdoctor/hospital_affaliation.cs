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
    
    public partial class hospital_affaliation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hospital_affaliation()
        {
            this.offices = new HashSet<office>();
        }
    
        public string hospital_id { get; set; }
        public string name { get; set; }
        public string doctor_id { get; set; }
        public string city { get; set; }
        public string Hospital_Address { get; set; }
    
        public virtual doctor doctor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<office> offices { get; set; }
    }
}