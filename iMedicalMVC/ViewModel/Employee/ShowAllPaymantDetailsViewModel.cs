using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Employee
{
    public class ShowAllPaymantDetailsViewModel
    {

        public int PaymentDetailsId { get; set; }

        public string PaymentDetailsNumber { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime PaymentDueDate { get; set; }
    }
}