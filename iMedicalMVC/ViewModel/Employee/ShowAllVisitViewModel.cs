using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Employee
{
    public class ShowAllVisitViewModel
    {

        public int IdVisit { get; set; }

        public string VisitNumber { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public DateTime? DateVisit { get; set; }
    }
}