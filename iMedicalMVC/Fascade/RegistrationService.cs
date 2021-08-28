using iMedicalMVC.DAO;
using iMedicalMVC.Helpers;
using iMedicalMVC.Models;
using iMedicalMVC.ViewModel.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Fascade
{
    public class RegistrationService
    {

        public void Save(RegistrationViewModel viewModel)
        {
            //VM -> Model
            Patient patient = new Patient();
            Login loginObject = new Login();

            patient.FirstName = viewModel.FirstName;
            patient.MiddleName = viewModel.MiddleName;
            patient.LastName = viewModel.LastName;
            patient.DateOfBirth = viewModel.DateOfBirth;
            patient.PESEL = viewModel.PESEL;
            patient.CountryRegistration = viewModel.CountryRegistration;
            patient.PostalCodeRegistration = viewModel.PostalCodeRegistration;
            patient.CityRegistration = viewModel.CityRegistration;
            patient.StreetRegistration = viewModel.StreetRegistration;
            patient.BuildingNumberRegistration = viewModel.BuildingNumberRegistration;
            patient.HousingNumberRegistration = viewModel.HousingNumberRegistration;
            patient.Email = viewModel.Email;
            patient.Phone = viewModel.Phone;
            patient.CountryResidence = viewModel.CountryResidence;
            patient.PostalCodeResidence = viewModel.PostalCodeResidence;
            patient.CityResidence = viewModel.CityResidence;
            patient.StreetResidence = viewModel.StreetResidence;
            patient.BuildingNumberResidence = viewModel.BuildingNumberResidence;
            patient.HouseNumberResidence = viewModel.HouseNumberResidence;
           
           loginObject.Login1 = viewModel.Login;
           loginObject.Password = SHAHelper.GenerateSHA512(viewModel.Password);
           
           patient.Login = loginObject;

          

            //Wywolanie metody z dao ktora zapisze dane 
            new RegistrationDao().Save(patient);
        }

        internal void Validate(RegistrationViewModel model)
        {

            var password = model.Password;
            var replayPassword = model.ReturnPassword;

            if (string.Compare(password, replayPassword) != 0)
            {
                throw new Exception("Walidacja sie nie udala");
            }

            //TODO nip walidacja

        }


    }
}