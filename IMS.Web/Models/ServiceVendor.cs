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
    
    public partial class ServiceVendor
    {
        public int serviceVendorId { get; set; }
        public string serviceCode { get; set; }
        public string vendorId { get; set; }
    
        public virtual HTV_Service HTV_Service { get; set; }
        public virtual HTV_Service HTV_Service1 { get; set; }
        public virtual HTV_Vendor HTV_Vendor { get; set; }
    }
}
