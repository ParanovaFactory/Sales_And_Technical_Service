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
    
    public partial class TblEmployee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblEmployee()
        {
            this.TblInvoiceBases = new HashSet<TblInvoiceBas>();
            this.TblProductAcceptances = new HashSet<TblProductAcceptance>();
            this.TblSales = new HashSet<TblSale>();
        }
    
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public Nullable<int> EmployeeDepartment { get; set; }
        public string EmployeeImage { get; set; }
        public string EmployeeMail { get; set; }
        public string EmployeePhone { get; set; }
    
        public virtual TblDepartment TblDepartment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblInvoiceBas> TblInvoiceBases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblProductAcceptance> TblProductAcceptances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSale> TblSales { get; set; }
    }
}
