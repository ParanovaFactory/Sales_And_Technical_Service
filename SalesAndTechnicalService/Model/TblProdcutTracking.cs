//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesAndTechnicalService.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblProdcutTracking
    {
        public int TrackingId { get; set; }
        public Nullable<int> TrackingProduct { get; set; }
        public string TrackingStatus { get; set; }
        public string TrackingDate { get; set; }
        public string TrackingCode { get; set; }
    
        public virtual TblProduct TblProduct { get; set; }
    }
}
