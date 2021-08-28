using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.ViewModel.Employee
{
    public class CreateNewContractViewModel
    {
        public SelectList EmployeeList { get; set; }

        public SelectList JobTypeList { get; set; }

        public SelectList TenureTypeList { get; set; }

        public SelectList ContracTypeList { get; set; }

        public SelectList MedicalFacilityList { get; set; }

        public int EmployeeListId { get; set; }

        public int JobTypeListId { get; set; }

        public int TenureTypeListId { get; set; }

        public int ContractTypeListId { get; set; }

        public int MedicalFacilityListId { get; set; }

        public string Bonu { get; set; }

        public string HourlyRate { get; set; }

        public string MonthRate { get; set; }

        public string Comments { get; set; }
        
        public string NumberAccount { get; set; }
        
        
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ConclusionDate { get; set; }

    



    }
}