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
    
    public partial class Billing_tenure
    {
        public int ID_Biling_tenure { get; set; }
        public Nullable<int> ID_Contract { get; set; }
        public Nullable<System.DateTime> Insertion_date { get; set; }
        public Nullable<System.DateTime> Date_from { get; set; }
        public Nullable<System.DateTime> Date_to { get; set; }
        public string Hours_number { get; set; }
        public string hours_extra_number { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }
        public string treatments_paid { get; set; }
        public string treatments_reimbursed { get; set; }
        public string visits_paid { get; set; }
        public string visits_reimbursed { get; set; }
        public string NumberBilling { get; set; }
    
        public virtual Contract Contract { get; set; }
    }
}
