using iMedicalMVC.DAO;
using iMedicalMVC.Models;
using iMedicalMVC.ViewModel.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Fascade
{
    public class JobTypeService
    {
        public List<JobTypeViewModel> GetAll()
        {
            var model = new JobTypeDao().GetAll();
            var result = new List<JobTypeViewModel>();
            foreach (var item in model)
            {
                result.Add(new JobTypeViewModel()
                {

                    Name = item.Name
                });
            }
            return result;
        }

        internal void AddJobType(CreateJobTypeViewModel model)
        {
            Job_Type jobType = new Job_Type();

            jobType.Name = model.Name;

            new JobTypeDao().Save(jobType);
        }


        internal void ValidateJobType(CreateJobTypeViewModel model)
        {

        }

    }
}