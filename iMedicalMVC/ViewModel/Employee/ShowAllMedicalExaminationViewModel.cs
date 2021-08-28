using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Employee
{
    public class ShowAllMedicalExaminationViewModel
    {

        public int MedicalExaminationId { get; set; }

        public string NumberMedicalExamination { get; set; }

        public DateTime? IssueDate { get; set; }
    }
}