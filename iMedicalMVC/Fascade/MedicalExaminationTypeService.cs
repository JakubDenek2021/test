using iMedicalMVC.DAO;
using iMedicalMVC.Models;
using iMedicalMVC.ViewModel.ContractType;
using iMedicalMVC.ViewModel.MedicalExaminationType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Fascade
{
    public class MedicalExaminationTypeService
    {
        public List<MedicalExaminationTypeViewModel> GetAll()
        {
            var model = new MedicalExaminationTypeDao().GetAll();
            var result = new List<MedicalExaminationTypeViewModel>();
            foreach (var item in model)
            {
                result.Add(new MedicalExaminationTypeViewModel()
                {

                    Name = item.Name
                });
            }
            return result;
        }

        internal void AddMedicalExaminationType(CreateMedicalExaminationTypeViewModel model)
        {
            Medical_examination_type medicalExaminationType = new Medical_examination_type();

            medicalExaminationType.Name = model.Name;
            
            new MedicalExaminationTypeDao().Save(medicalExaminationType);
        }


        internal void ValidateMedicalExaminationType(CreateMedicalExaminationTypeViewModel model)
        {

        }

        public List<MedicalExaminationTypeListViewModel> GetAllMedicalExaminationTypelist()
        {
            var model = new MedicalExaminationTypeDao().GetAllMedicalExaminationTypelist();
            var result = new List<MedicalExaminationTypeListViewModel>();
            foreach (var item in model)
            {
                result.Add(new MedicalExaminationTypeListViewModel()
                {
                    ID = item.ID_medical_examination_type,
                    Name = item.Name 

                });
            }
            return result;
        }

    }
}