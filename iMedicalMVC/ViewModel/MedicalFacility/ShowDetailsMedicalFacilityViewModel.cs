using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.MedicalFacility
{
    public class ShowDetailsMedicalFacilityViewModel
    {
        public int IdMedicalFacility { get; set; }
        public string Long_name { get; set; }

        public string Short_name { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public string Street { get; set; }

        public string BuildingNumber { get; set; }

        public string NIP { get; set; }

        public string Status { get; set; }
    }
}