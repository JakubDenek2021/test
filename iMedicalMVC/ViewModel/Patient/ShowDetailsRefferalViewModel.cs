using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Patient
{
    public class ShowDetailsRefferalViewModel
    {
        public int ReferralId { get; set; }

        public string RefferalNumber { get; set; }

        public DateTime? Issue_Date { get; set; }

        public int? RefferalCode { get; set; }

        public string Description { get; set; }
    }
}