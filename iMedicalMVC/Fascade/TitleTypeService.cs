using iMedicalMVC.DAO;
using iMedicalMVC.Models;
using iMedicalMVC.ViewModel.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Fascade
{
    public class TitleTypeService
    {
        public List<TitleTypeViewModel> GetAll()
        {
            var model = new TitleTypeDao().GetAll();
            var result = new List<TitleTypeViewModel>();
            foreach (var item in model)
            {
                result.Add(new TitleTypeViewModel()
                {

                    Name = item.Name
                });
            }
            return result;
        }

        internal void AddTitleType(CreateTitleTypeViewModel model)
        {
            Title_Type titleType = new Title_Type();

            titleType.Name = model.Name;

            new TitleTypeDao().Save(titleType);
        }


        internal void ValidateTitleType(CreateTitleTypeViewModel model)
        {

        }

    }
}