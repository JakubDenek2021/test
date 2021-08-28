using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.ViewModel.Employee
{
    public class CreateMedicalExaminationViewModel
    {
        public SelectList PatientList { get; set; }
        public int PatientListId { get; set; }

        public SelectList MedicalExaminationList { get; set; }
        public int MedicalExaminationListId { get; set; }

        public string NumberReferral { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime IssueDate { get; set; }


    }
}