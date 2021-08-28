using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.ViewModel.Employee
{
    public class CreateNewBillingViewModel
    {
        public SelectList ContractList { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Insertion_date { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date_from { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date_to { get; set; }
        public string Hours_number { get; set; }
        public string hours_extra_number { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }
        public string treatments_paid { get; set; }
        public string treatments_reimbursed { get; set; }
        public string visits_paid { get; set; }
        public string visits_reimbursed { get; set; }

        public int ContractListId { get; set; }
    }
}