using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.ViewModel.Doctor
{
    public class AddNewPrescriptionViewModel
    {
        public SelectList PatientList { get; set; }
        public int PatientListId { get; set; }
        public SelectList VisitNumberList { get; set; }
        public int VisitNumberListId { get; set; }
        public string Medication1 { get; set; }

        public string Medication2 { get; set; }

        public string Medication3 { get; set; }

        public string Medication4 { get; set; }

        public string Medication5 { get; set; }

        public string Medication6 { get; set; }

        public string Medication7 { get; set; }

        public string Dose1 { get; set; }

        public string Dose2 { get; set; }

        public string Dose3 { get; set; }
        public string Dose4 { get; set; }
        public string Dose5 { get; set; }
        public string Dose6 { get; set; }
        public string Dose7 { get; set; }







    }
}