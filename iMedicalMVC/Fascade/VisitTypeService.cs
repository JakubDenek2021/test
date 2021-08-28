using iMedicalMVC.DAO;
using iMedicalMVC.Models;
using iMedicalMVC.ViewModel.ContractType;
using iMedicalMVC.ViewModel.Visit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Fascade
{
    public class VisitTypeService
    {
        public List<VisitTypeViewModel> GetAll()
        {
            var model = new VisitTypeDao().GetAll();
            var result = new List<VisitTypeViewModel>();
            foreach (var item in model)
            {
                result.Add(new VisitTypeViewModel()
                {

                    Name = item.Name
                });
            }
            return result;
        }

        internal void AddVisitType(CreateVisitTypeViewModel model)
        {
            Visit_type visitType = new Visit_type();

            visitType.Name = model.Name;

            new VisitTypeDao().Save(visitType);
        }


        internal void ValidateVisitType(CreateVisitTypeViewModel model)
        {

        }

        public List<VisitListViewModel> GetAllVisitlist()
        {
            var model = new VisitDao().GetAllVisitlist();
            var result = new List<VisitListViewModel>();
            foreach (var item in model)
            {
                result.Add(new VisitListViewModel()
                {
                    Id = item.ID_Visit,
                    NumberVisit = item.VisitNumber

                });
            }
            return result;
        }

    }
}