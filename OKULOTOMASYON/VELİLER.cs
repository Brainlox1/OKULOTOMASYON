//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OKULOTOMASYON
{
    using System;
    using System.Collections.Generic;
    
    public partial class VELİLER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VELİLER()
        {
            this.OGRENCİLER = new HashSet<OGRENCİLER>();
        }
    
        public int VELİID { get; set; }
        public string VELİANNE { get; set; }
        public string VELİBABA { get; set; }
        public string VELİTEL1 { get; set; }
        public string VELİTEL2 { get; set; }
        public string VELİMAİL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OGRENCİLER> OGRENCİLER { get; set; }
    }
}
