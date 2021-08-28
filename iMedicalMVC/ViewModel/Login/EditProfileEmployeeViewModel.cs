using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Login
{
    public class EditProfileEmployeeViewModel
    {

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime DateOfBirth { get; set; }
        public string PESEL { get; set; }
        public string CountryRegistration { get; set; }
        public string PostalCodeRegistration { get; set; }
        public string CityRegistration { get; set; }
        public string StreetRegistration { get; set; }
        public string BuildingNumberRegistration { get; set; }
        public string HousingNumberRegistration { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CountryResidence { get; set; }
        public string PostalCodeResidence { get; set; }
        public string CityResidence { get; set; }
        public string StreetResidence { get; set; }
        public string BuildingNumberResidence { get; set; }
        public string HouseNumberResidence { get; set; }

 
    }
}