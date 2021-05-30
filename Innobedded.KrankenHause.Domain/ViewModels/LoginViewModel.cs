using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Domain.ViewModels
{
  public  class LoginViewModel
    {
        [Display(Name = "User Name ")]
        [MaxLength(15)]
        [Required(ErrorMessage ="Please Enter {0}")]
        public string UserName { get; set; }


        [Display(Name = "Password ")]
        [Required(ErrorMessage ="Please Enter {0}")]
        [MaxLength(15)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me!")]
        public bool Remember { get; set; }
    }
}
