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
        [Display(Name = "Nutzername")]
        [MaxLength(20)]
        public string UserName { get; set; }


        [Display(Name = "Passwort")]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me!")]
        public bool Remember { get; set; }
    }
}
