using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Employee
{
    public class ShowDetailsContractViewModel
    {
      

        public int? EmployeeId { get; set; }

        public int? JobTypeId { get; set; }

        public int? TenureTypeId { get; set; }

        public int? ContractTypeId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string TenureName { get; set; }

        public string ContractTypName { get; set; }

        public string JobTypeName { get; set; }

        public string Bonu { get; set; }

        public string HourlyRate { get; set; }

        public string MonthRate { get; set; }

        public string Comments { get; set; }

        public string NumberAccount { get; set; }

        public DateTime? ConclusionDate { get; set; }


        public string NumberContract { get; set; }

    }
}