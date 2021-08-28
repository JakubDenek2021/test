using iMedicalMVC.DAO;
using iMedicalMVC.Models;
using iMedicalMVC.ViewModel.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Fascade
{
    public class PrescriptionService
    {
        public void SavePrescription(AddNewPrescriptionViewModel viewModel)
        {
            //VM -> Model
            Prescription prescription = new Prescription();

            prescription.Medication_1 = viewModel.Medication1;
            prescription.Medication_2 = viewModel.Medication2;
            prescription.Medication_3 = viewModel.Medication3;
            prescription.Medication_4 = viewModel.Medication4;
            prescription.Medication_5 = viewModel.Medication5;
            prescription.Medication_6 = viewModel.Medication6;
            prescription.Medication_7 = viewModel.Medication7;
            prescription.Dose_1 = viewModel.Dose1;
            prescription.Dose_2 = viewModel.Dose2;
            prescription.Dose_3 = viewModel.Dose3;
            prescription.Dose_4 = viewModel.Dose4;
            prescription.Dose_5 = viewModel.Dose5;
            prescription.Dose_6 = viewModel.Dose6;
            prescription.Dose_7 = viewModel.Dose7;
            prescription.ID_Visit = viewModel.VisitNumberListId;
            prescription.ID_Patient = viewModel.PatientListId;

           

            //Wywolanie metody z dao ktora zapisze dane 
            new PrescriptionDao().SavePrescription(prescription);
        }

        internal void ValidateNewPrescription(AddNewPrescriptionViewModel model)
        {

        }
    }
}