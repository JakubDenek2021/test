using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.ViewModel.Employee
{
    public class CreateNewVistViewModel
    {

        public SelectList EmployeeList { get; set; }

        public int EmployeeListId { get; set; }

        public SelectList PatientList { get; set; }
        public int PatientListId { get; set; }

        public SelectList VisitTypeList { get; set; }
        public int VisitTypeListId { get; set; }

        public string Comments { get; set; }
        [DataType(DataType.DateTime)]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime DateHourVisitStart { get; set; }     



    }
}