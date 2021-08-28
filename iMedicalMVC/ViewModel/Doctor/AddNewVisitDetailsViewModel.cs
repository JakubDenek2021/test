using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.ViewModel.Doctor
{
    public class AddNewVisitDetailsViewModel
    {

 
        public string ActivitiesPerformed { get; set; }

        public string Recomendations { get; set; }

        public string GeneralInfomration { get; set; }

        public string DoageOfMedication { get; set; }

        public string Comments { get; set; }

        public int VisitId { get; set; }
    }
}