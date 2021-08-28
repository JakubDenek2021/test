using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.ViewModel.Employee
{
    public class CreateMedicDetailsViewModel
    {
        public SelectList MedicalExaminationList { get; set; }
        public int MedicalExaminationListId { get; set; }

        public string Result1 { get; set; }

        public string Result2 { get; set; }

        public string Result3 { get; set; }

        public string Result4 { get; set; }

        public string Recommendations { get; set; }
    }
}