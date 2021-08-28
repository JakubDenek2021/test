using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Views.Patient
{
    public class ShowPrescriptionDetailsViewModel
    {
        public int PrescriptionId { get; set; }

        public string NumberPrescription { get; set; }

        public string Medication_1 { get; set; }
        public string Medication_2 { get; set; }
        public string Medication_3 { get; set; }
        public string Medication_4 { get; set; }
        public string Medication_5 { get; set; }
        public string Medication_6 { get; set; }
        public string Medication_7 { get; set; }

        public string Dose_1 { get; set; }
        public string Dose_2 { get; set; }
        public string Dose_3 { get; set; }
        public string Dose_4 { get; set; }
        public string Dose_5 { get; set; }
        public string Dose_6 { get; set; }
        public string Dose_7 { get; set; }

        public DateTime? IssueDate { get; set; }

        public int? PrescriptionCode { get; set; }





    }
}