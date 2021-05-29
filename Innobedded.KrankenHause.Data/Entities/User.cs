using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Data.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Display(Name = "Nutzername")]
        public string UserName { get; set; }


        [Display(Name = "Passwort")]
        public string Password { get; set; }

        [Display(Name = "vor und NachName")]
        public string NameFamily { get; set; }

        [Display(Name = "Letzte Besuch")]
        public DateTime LastEnter { get; set; }


        public virtual ICollection<Reception> Receptions { get; set; }
    }
}
