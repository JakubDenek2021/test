using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.ContractType
{
    public class CreatePriceListViewModel
    {
        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }


    }
}