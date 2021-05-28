using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Data.Entities
{
   public class Klinik
    {
        [Key]
        public int KlinikID { get; set; }

         [Display(Name ="Klinik Name")]
        public string Name { get; set; }

         [Display(Name ="Über Klinik")]
        [DataType(DataType.MultilineText)]
        [MaxLength(350)]
        public string Description { get; set; }

         [Display(Name ="Klinik Bild")]
        public string Picture { get; set; }

         [Display(Name ="Art Klinik")]
        [Required(ErrorMessage ="Wählen Sie {0} Bitte!")]
        public int KlinikTypeID { get; set; }



        public virtual KlinikType KlinikType { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }

        public virtual ICollection<Reception>  Receptions { get; set; }

    }
}
