using iMedicalMVC.DAO;
using iMedicalMVC.ViewModel.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Fascade
{
    public class AccountService
    {
        internal ShowDetailsProfileEmployeeViewModel GetEmployeeProfile(int loginId)
        {
            var model = new ProfileDao().GetEmployee(loginId);

            var result = new ShowDetailsProfileEmployeeViewModel()
            {
                FirstName = model.FirstName + " " + model.LastName,
                MiddleName = model.MiddleName,
                DateOfBirth = (DateTime)model.DateOfBirth,
                Number_Employee = model.Number_Employee,
                PESEL = model.PESEL,
                CountryRegistration = model.CountryRegistration,
                PostalCodeRegistration = model.PostalCodeRegistration,
                CityRegistration = model.CityRegistration,
                StreetRegistration = model.StreetRegistration,
                BuildingNumberRegistration = model.BuildingNumberRegistration,
                HousingNumberRegistration = model.HousingNumberRegistration,
                Email = model.Email,
                Phone = model.Phone,
                CountryResidence = model.CountryResidence,
                CityResidence = model.CityResidence,
                PostalCodeResidence = model.CityResidence,
                StreetResidence = model.StreetResidence,
                BuildingNumberResidence = model.BuildingNumberResidence,
                HouseNumberResidence = model.HouseNumberResidence


            };
            return result;
        }

        internal ShowDetailsProfilePatientViewModel GetPatientProfile(int loginId)
        {
            var model = new ProfileDao().GetPatient(loginId);

            var result = new ShowDetailsProfilePatientViewModel()
            {
                FirstName = model.FirstName + " " + model.LastName,
                MiddleName = model.MiddleName,
                Number_Patient = model.Number_Patient,
                PESEL = model.PESEL,
                CountryRegistration = model.CountryRegistration,
                PostalCodeRegistration = model.PostalCodeRegistration,
                CityRegistration = model.CityRegistration,
                StreetRegistration = model.StreetRegistration,
                BuildingNumberRegistration = model.BuildingNumberRegistration,
                HousingNumberRegistration = model.HousingNumberRegistration,
                Email = model.Email,
                Phone = model.Phone,
                CountryResidence = model.CountryResidence,
                CityResidence = model.CityResidence,
                PostalCodeResidence = model.CityResidence,
                StreetResidence = model.StreetResidence,
                BuildingNumberResidence = model.BuildingNumberResidence,
                HouseNumberResidence = model.HouseNumberResidence


            };
            return result;
        }

    }
}