using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.MedicalFacility
{
    public class EditMedicalFacilityViewModel
    {
        public int IdMedicalFacility { get; set; }
        public string LongName { get; set; }

        public string ShortName { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public string Street { get; set; }

        public string BuilidingNumber { get; set; }

        public string NIP { get; set; }

        public string Status { get; set; }
    }
}