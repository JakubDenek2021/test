using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Patient
{
    public class ShowAllPrescriptionPatientViewModel
    {

        public int PrescriptionId { get; set; }

        public string NumberPrescription { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? IssueDate { get; set; }
    }
}