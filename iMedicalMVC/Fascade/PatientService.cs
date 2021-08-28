using iMedicalMVC.DAO;
using iMedicalMVC.ViewModel.Doctor;
using iMedicalMVC.ViewModel.Employee;
using iMedicalMVC.ViewModel.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Fascade
{
    public class PatientService
    {
        public List<ShowAllPatientViewModel> GetAll()
        {
            var model = new PatientDao().GetAll();
            var result = new List<ShowAllPatientViewModel>();
            foreach (var item in model)
            {
                result.Add(new ShowAllPatientViewModel()
                {

                  FirstName = item.FirstName,
                  LastName = item.LastName,
                  PESEL = item.PESEL,
                  Phone = item.Phone
                });
            }
            return result;
        }

    

        public List<PatientListViewModel> GetAllPatientlist()
        {
            var model = new PatientDao().GetAllPatientlist();
            var result = new List<PatientListViewModel>();
            foreach (var item in model)
            {
                result.Add(new PatientListViewModel()
                {
                    ID = item.ID_Patient,
                    NumberPatient = item.Number_Patient + " (" + item.FirstName + " " + item.LastName + ")"

                });
            }
            return result;
        }

        public List<MedicalExaminationListViewModel> GetAllMedicalExaminationlist()
        {
            var model = new PatientDao().GetAllMedicalExaminationlist();
            var result = new List<MedicalExaminationListViewModel>();
            foreach (var item in model)
            {
                result.Add(new MedicalExaminationListViewModel()
                {
                    ID = item.ID_Medical_examination,
                    NumberPatient = item.NumberMedicalExamination 
                });
            }
            return result;
        }

    }
}