//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iMedicalMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contract()
        {
            this.Billing_tenure = new HashSet<Billing_tenure>();
            this.Payment_Details = new HashSet<Payment_Details>();
        }
    
        public int ID_Contract { get; set; }
        public Nullable<int> ID_Contract_Type { get; set; }
        public Nullable<int> ID_Tenure_type { get; set; }
        public Nullable<int> ID_Employee { get; set; }
        public Nullable<int> ID_Job_Type { get; set; }
        public string Bonus { get; set; }
        public string HourlyRate { get; set; }
        public string MonthlyRate { get; set; }
        public string Comments { get; set; }
        public string NumberAccount { get; set; }
        public Nullable<System.DateTime> ConclusionDate { get; set; }
        public string NumberContract { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Billing_tenure> Billing_tenure { get; set; }
        public virtual Contract_Type Contract_Type { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Job_Type Job_Type { get; set; }
        public virtual Tenure_type Tenure_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment_Details> Payment_Details { get; set; }
    }
}
