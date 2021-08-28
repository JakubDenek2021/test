using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.ViewModel.Employee
{
    public class CreateParamedicalViewModel
    {
        public SelectList EmployeeList { get; set; }

        public SelectList TitleTypeList { get; set; }

        [Required]
        public string PWZ { get; set; }
        [Required]
        public string CertificateNumber { get; set; }


        public int TitleTypeListId { get; set; }

        public int EmployeeListId { get; set; }
    }
}