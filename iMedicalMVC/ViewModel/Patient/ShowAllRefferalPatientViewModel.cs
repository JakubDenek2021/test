using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Patient
{
    public class ShowAllRefferalPatientViewModel
    {
        public int ReferralId { get; set; }

        public string NumberRefferal { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? IssueDate { get; set; }
    }
}