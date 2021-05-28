using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Data.Entities
{
   public class Krank
    {
        [Key]
        public int KrankID { get; set; }

         [Display(Name ="VorName")]
        public string Name { get; set; }

         [Display(Name ="NachName")]
        public string Family { get; set; }

         [Display(Name ="Addrese")]
          [MaxLength(300)]
        public string Address { get; set; }

         [Display(Name = "Geburtstag")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime Born { get; set; }

        [Display(Name = "Beschreibung")]
        [DataType(DataType.MultilineText)]
        [MaxLength(350)]
        public string Description { get; set; }


        [Display(Name = "Versicherung")]
        [Required(ErrorMessage = "Wählen Sie {0} Bitte!")]
        public int InsuranceID { get; set; }

        [Display(Name = "Das Geschlecht")]
        [Required(ErrorMessage = "Wählen Sie {0} Bitte!")]
        public int SexID { get; set; }


        [Display(Name = "Das Job")]
        [Required(ErrorMessage = "Wählen Sie {0} Bitte!")]
        public int JobID { get; set; }

        [Display(Name = "Bildungs")]
        [Required(ErrorMessage = "Wählen Sie {0} Bitte!")]
        public int EduID { get; set; }




        public virtual Sex Sex { get; set; }
        public virtual Job Job { get; set; }

        public virtual Education Education { get; set; }

        public virtual Insurance Insurance { get; set; }

        public virtual ICollection<Reception> Receptions { get; set; }

    }
}
