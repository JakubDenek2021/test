using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Employee
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CountryRegistration { get; set; }

        public string NumberEmployee { get; set; }

        public string Email { get; set; }
    }
}