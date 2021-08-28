using iMedicalMVC.DAO;
using iMedicalMVC.Models;
using iMedicalMVC.ViewModel.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Fascade
{
    public class TenureTypeService
    {
        public List<TenureTypeViewModel> GetAll()
        {
            var model = new TenureTypeDao().GetAll();
            var result = new List<TenureTypeViewModel>();
            foreach (var item in model)
            {
                result.Add(new TenureTypeViewModel()
                {

                    Name = item.Name
                });
            }
            return result;
        }

        internal void AddTenureType(CreateTenureTypeViewModel model)
        {
            Tenure_type tenureType = new Tenure_type();

            tenureType.Name = model.Name;

            new TenureTypeDao().Save(tenureType);
        }


        internal void ValidateTenureType(CreateTenureTypeViewModel model)
        {

        }

    }
}