using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Data.Entities
{


  public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }

        [Display(Name ="VorName")]
        public string Name { get; set; }

        [Display(Name = "NachName")]
        public string Family { get; set; }

         [Display(Name ="Ärtz Fach")]
        [Required(ErrorMessage = "Bitte wählen Sie {0} ...")]
        public int FachID { get; set; }

        [Display(Name = "Klinik Name")]
        [Required(ErrorMessage = "Bitte wählen Sie {0} ...")]
        public int KlinikID { get; set; }

        [Display(Name = "Telefon Nummer")]
        public string Telefon { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [MinLength(10)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Beschreibung")]
        [DataType(DataType.MultilineText)]
        [MaxLength(350)]
        public string Description { get; set; }

        [Display(Name = "Ärtz*in Bild")]
        public string Picture { get; set; }

        public virtual Fach Fach { get; set; }
        public virtual Klinik Klinik { get; set; }
    }
}
