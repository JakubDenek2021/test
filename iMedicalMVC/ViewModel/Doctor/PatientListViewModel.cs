using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Doctor
{
    public class PatientListViewModel
    {
        public int ID { get; set; }

        public string NumberPatient { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}