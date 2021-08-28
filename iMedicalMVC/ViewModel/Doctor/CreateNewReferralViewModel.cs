using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.ViewModel.Doctor
{
    public class CreateNewReferralViewModel
    {
       public SelectList PatientList { get; set; }

       public SelectList MedicalExaminationTypeList { get; set; }

        public string Description{ get; set; }
      
       public int MedicalExaminationTypeListId { get; set; }

      public int PatientListId { get; set; }
    }
}