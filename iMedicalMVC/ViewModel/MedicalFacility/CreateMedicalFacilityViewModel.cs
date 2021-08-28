using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.ViewModel.MedicalFacility
{


    public class CreateMedicalFacilityViewModel
    {
        public SelectList MedicalFacilityList { get; set; }

        [Required]
        public string Long_name { get; set; }

        [Required]
        public string Short_name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string BuildingNumber { get; set; }
        public string HouseNumber { get; set; }
        public string NIP { get; set; }
        [Required]
        public string Status { get; set; }

        public int MedicalFacilityBranchType { get; set; }
    }
}