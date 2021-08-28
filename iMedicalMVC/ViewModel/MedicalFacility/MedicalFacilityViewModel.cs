using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.MedicalFacility
{
    public class MedicalFacilityViewModel
    {

        public int IdMedicalFacility { get; set; }
        public string Short_name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}