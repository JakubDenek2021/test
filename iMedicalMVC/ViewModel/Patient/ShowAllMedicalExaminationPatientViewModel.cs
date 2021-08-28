using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Patient
{
    public class ShowAllMedicalExaminationPatientViewModel
    {

        public int MedicalExaminationId { get; set; }

        public string NumberMedicalExamination { get; set; }

   
        public DateTime? IssueDate { get; set; }

    }
}