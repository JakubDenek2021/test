using iMedicalMVC.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Login
{
    public class ChangePasswordViewModel : IPassword, ILogin
    {
        public string Login { get; set; }


        [Display(Name = "Nowe Hasło")]
        [Required]
        [DataType(DataType.Password)]
        [StringLength(32, MinimumLength = 3)]
        public string Password { get; set; }

        [Display(Name = "Powtórz noew hasło ")]
        [Required]
        [DataType(DataType.Password)]
        [StringLength(32, MinimumLength = 3)]
        public string ReplayNewPassword { get; set; }
    }
}