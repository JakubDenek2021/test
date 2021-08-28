using iMedicalMVC.DAO;
using iMedicalMVC.Infrastructure;
using iMedicalMVC.Models;
using iMedicalMVC.ViewModel.Doctor;
using iMedicalMVC.ViewModel.Employee;
using iMedicalMVC.ViewModel.Login;
using iMedicalMVC.ViewModel.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Fascade
{
    public class ProfileService
    {
        internal ShowDetailsPatientViewModel GetPatientName(int loginId)
        {
            var model = new ProfileDao().GetPatient(loginId);

            var result = new ShowDetailsPatientViewModel()
            {
                Name = model.FirstName,
                LastName = model.LastName,
                Phone = model.Phone,
                StreetRegistration = model.StreetRegistration,
                HouseNumberRegistration = model.HousingNumberRegistration,
                Email = model.Email

            };
            return result;
        }
        internal ShowDetailsEmployeeViewModel GetEmployeeName(int loginId)
        {
            var model = new ProfileDao().GetEmployee(loginId);

            var result = new ShowDetailsEmployeeViewModel()
            {
                Name = model.FirstName,
                LastName = model.LastName,
                Phone = model.Phone,
                StreetRegistration = model.StreetRegistration,
                HouseNumberRegistration = model.HousingNumberRegistration,
                Email = model.Email
            };
            return result;
        }

        internal EditProfileEmployeeViewModel GetEmployeeProfileToEdit(int loginId)
        {
            var model = new MedicalFaclityDao().GetEmployee(loginId);

            var result = new EditProfileEmployeeViewModel()
            {
               PESEL = model.PESEL,
            CountryRegistration = model.CountryRegistration,
            CityRegistration = model.CityRegistration,
            PostalCodeRegistration = model.PostalCodeRegistration,
            StreetRegistration = model.StreetRegistration,
            HousingNumberRegistration = model.HousingNumberRegistration,
            BuildingNumberRegistration = model.BuildingNumberRegistration,
            CountryResidence = model.CountryResidence,
            CityResidence = model.CityResidence,
            PostalCodeResidence = model.PostalCodeResidence,
            StreetResidence = model.StreetResidence,
            BuildingNumberResidence = model.BuildingNumberResidence,
            HouseNumberResidence = model.HouseNumberResidence,
            Email = model.Email,
            Phone = model.Phone,

        };
            return result;
        }

        internal AddNewVisitDetailsViewModel GetVisitToEdit(int visitId)
        {
            var model = new MedicalFaclityDao().GetVisit(visitId);

            var result = new AddNewVisitDetailsViewModel()
            {
               ActivitiesPerformed = model.Activities_performed,
               Recomendations = model.Recomendations,
               GeneralInfomration = model.General_information,
               DoageOfMedication = model.Dosage_of_medication,
               Comments = model.Comments

            };
            return result;
        }


        internal void Edit(EditProfileEmployeeViewModel model)
        {
            var employeeDao = new MedicalFaclityDao();
            var modelDb = employeeDao.GetEmployee(new SessionContext().GetLoginId());

            modelDb.PESEL = model.PESEL;
            modelDb.CountryRegistration = model.CountryRegistration;
            modelDb.CityRegistration = model.CityRegistration;
            modelDb.PostalCodeRegistration = model.PostalCodeRegistration;
            modelDb.StreetRegistration = model.StreetRegistration;
            modelDb.HousingNumberRegistration = model.HousingNumberRegistration;
            modelDb.BuildingNumberRegistration = model.BuildingNumberRegistration;
            modelDb.CountryResidence = model.CountryResidence;
            modelDb.CityResidence = model.CityResidence;
            modelDb.PostalCodeResidence = model.PostalCodeResidence;
            modelDb.StreetResidence = model.StreetResidence;
            modelDb.BuildingNumberResidence = model.BuildingNumberResidence;
            modelDb.HouseNumberResidence = model.HouseNumberResidence;
            modelDb.Email = model.Email;
            modelDb.Phone = model.Phone;


            employeeDao.Update(modelDb);


        }

        internal void EditVisit(AddNewVisitDetailsViewModel model)
        {

            var visit = new MedicalFaclityDao();
            var m = visit.GetVisit(model.VisitId);


            m.Comments = model.Comments;
            m.Activities_performed = model.ActivitiesPerformed;
            m.Recomendations = model.Recomendations;
            m.General_information = model.GeneralInfomration;
            m.Dosage_of_medication = model.DoageOfMedication;
            visit.Update(m);


            //Wywolanie metody z dao ktora zapisze dane 
            






        }
    }
}