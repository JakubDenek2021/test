using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.ViewModel.Employee
{
    public class CreateNewPaymantDetailsViewModel
    {
        public SelectList BillingList { get; set; }

        public SelectList ContractList { get; set; }

        public int BillingListId { get; set; }

        public int ContractListId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime Payment_date { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime Payment_due_date { get; set; }
        public int Total { get; set; }
        public string Title { get; set; }
        public string Comments { get; set; }
    }
}