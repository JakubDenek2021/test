using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.ContractType
{
    public class CreateTenureTypeViewModel
    {
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
    }
}