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
    
    public partial class office
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public office()
        {
            this.appointments = new HashSet<appointment>();
            this.doctor_avaliability = new HashSet<doctor_avaliability>();
        }
    
        public string office_id { get; set; }
        public string doctor_id { get; set; }
        public string hospital_affaliation_id { get; set; }
        public string clinic_affaliation_id { get; set; }
        public string city { get; set; }
        public int consultant_fee { get; set; }
        public string time_slot { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<appointment> appointments { get; set; }
        public virtual clinic_affaliation clinic_affaliation { get; set; }
        public virtual doctor doctor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<doctor_avaliability> doctor_avaliability { get; set; }
        public virtual hospital_affaliation hospital_affaliation { get; set; }
    }
}
