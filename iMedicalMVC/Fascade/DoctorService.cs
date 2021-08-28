using iMedicalMVC.DAO;
using iMedicalMVC.Models;
using iMedicalMVC.ViewModel.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Fascade
{
    public class DoctorService
    {
        

        public void SaveReferral(CreateNewReferralViewModel viewModel)
        {
            //VM -> Model
            Referral referral = new Referral();


            referral.Description = viewModel.Description;
          referral.ID_medical_examination_type = viewModel.MedicalExaminationTypeListId;
            referral.ID_Patient = viewModel.PatientListId;
           

            //Wywolanie metody z dao ktora zapisze dane 
            new DoctorDao().SaveReferral(referral);
        }

        internal void ValidateNewReferral(AddNewVisitDetailsViewModel model)
        {
            //throw new NotImplementedException();
        }

        //public void SaveNewVisit(AddNewVisitDetailsViewModel viewModel)
        //{
        //    //VM -> Model
        //    Visit_Details visitDetails = new Visit_Details();

        //    visitDetails.Activities_performed = viewModel.ActivitiesPerformed;
        //    visitDetails.Recomendations = viewModel.Recomendations;
        //    visitDetails.General_information = viewModel.GeneralInfomration;
        //    visitDetails.Dosage_of_medication = viewModel.DoageOfMedication;
        //    visitDetails.Comments = viewModel.Comments;
        //    visitDetails.ID_Visit = viewModel.VisitNumberListId;

        //    //Wywolanie metody z dao ktora zapisze dane 
        //    new DoctorDao().SaveNewVisit(visitDetails);
        //}

        internal void ValidateNewVisit(AddNewVisitDetailsViewModel model)
        {

        }
    }
}