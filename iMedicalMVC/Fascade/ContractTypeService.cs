using iMedicalMVC.DAO;
using iMedicalMVC.Models;
using iMedicalMVC.ViewModel.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Fascade
{
    public class ContractTypeService
    {
        public List<ContractTypeViewModel> GetAll()
        {
            var model = new ContractTypeDao().GetAll();
            var result = new List<ContractTypeViewModel>();
            foreach (var item in model)
            {
                result.Add(new ContractTypeViewModel()
                {

                    Name = item.Name
                });
            }
            return result;
        }

        internal void AddContractType(CreateContractTypeViewModel model)
        {
            Contract_Type contractType = new Contract_Type();

            contractType.Name = model.Name;

            new ContractTypeDao().Save(contractType);
        }


        internal void ValidateContractType(CreateContractTypeViewModel model)
        {

        }

    }
}