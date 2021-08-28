using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Account
{
    public class RegistrationViewModel
    {
        [Display(Name = "Imię")]
       
        public string FirstName { get; set; }
        [Display(Name = "Drugie imię")]
        public string MiddleName { get; set; }
        [Display(Name = "Nazwisko")]
       
        public string LastName { get; set; }
        
        [Display(Name = "PESEL")]
        public string PESEL { get; set; }

        [Display(Name = "Kraj zameldowania")]
        
        public string CountryRegistration { get; set; }

        [Display(Name = "Kod pocztowy zameldowania")]
        
        public string PostalCodeRegistration { get; set; }

        [Display(Name = "Miejscowość zameldowania")]
        
        public string CityRegistration { get; set; }

        [Display(Name = "Ulica zameldowania")]
        
        public string StreetRegistration { get; set; }

        [Display(Name = "Nr budynku zameldowania")]
        
        public string BuildingNumberRegistration { get; set; }

        [Display(Name = "Nr lokalu zameldowania")]
        public string HousingNumberRegistration { get; set; }

        [Display(Name = "Email")]

        public string Email { get; set; }

        [Display(Name = "Telefon")]
       
        public string Phone { get; set; }

        [Display(Name = "Kraj zamieszkania")]
        public string CountryResidence { get; set; }

        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Kod pocztowy zamieszkania")]
        public string PostalCodeResidence { get; set; }
        [Display(Name = "Miejscowość zamieszkania")]
        public string CityResidence { get; set; }

        [Display(Name = "Ulica zamieszkania")]
        public string StreetResidence { get; set; }

        [Display(Name = "Nr budynku zamieszkania")]
        public string BuildingNumberResidence { get; set; }

        [Display(Name = "Nr lokalu zamieszkania")]
        public string HouseNumberResidence { get; set; }

        [Display(Name = "Login")]
   
        public string Login { get; set; }

        [Display(Name = "Hasło")]
 
        public string Password { get; set; }

        [Display(Name = "Powtórz hasło")]

        public string ReturnPassword { get; set; }
    }
}