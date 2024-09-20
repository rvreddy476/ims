//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMS.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InwardMaterial_OPEX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InwardMaterial_OPEX()
        {
            this.RejectedInvMaterials = new HashSet<RejectedInvMaterial>();
        }
    
        public string InvMaterialOP_ID { get; set; }
        public string InwardID { get; set; }
        public string MaterialID { get; set; }
        public string Material_Name { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Inward_Type { get; set; }
        public string Status { get; set; }
        public string Acceptedby { get; set; }
        public string Material_Remark { get; set; }
        public Nullable<int> Material_CategoryID { get; set; }
        public Nullable<System.DateTime> Accepted_Date { get; set; }
    
        public virtual InwardMaterial InwardMaterial { get; set; }
        public virtual Material_Category Material_Category { get; set; }
        public virtual Material Material { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RejectedInvMaterial> RejectedInvMaterials { get; set; }
    }
}
