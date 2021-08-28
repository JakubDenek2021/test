using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Specialization
{
    public class CreateSpecializationViewModel
    {
        [Required]
        [MaxLength(64)]
        public string Name { get; set; }
    }
}