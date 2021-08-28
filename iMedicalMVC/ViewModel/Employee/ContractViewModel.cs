using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Employee
{
    public class ContractViewModel
    {
        public int ContractId { get; set; }
        public string NumberContrat { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate { get; set; }

        
        public string EmployeNumber { get; set; }
    }
}