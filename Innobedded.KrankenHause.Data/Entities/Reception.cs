using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Data.Entities
{
  public  class Reception
    {

        [Key]
        public int ReceptionID { get; set; }

        [Display(Name = "Krank")]
        [Required(ErrorMessage = "Wählen Sie {0} Bitte!")]
        public int KrankID { get; set; }

        [Display(Name = "Klinik")]
        [Required(ErrorMessage = "Wählen Sie {0} Bitte!")]
        public int KlinikID { get; set; }

        [Display(Name = "System Benutzer")]
        [Required(ErrorMessage = "Wählen Sie {0} Bitte!")]
        public int UserID { get; set; }

         [Display(Name = "Akzeptieren")]
        public bool Accept { get; set; }

         [Display(Name ="Was ist Problems oder Krankheit")]
        public string CauseDescription { get; set; }

        [Display(Name = "Rezeption Date")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime ReceptionTime { get; set; }




        public virtual Krank Krank { get; set; }
        public virtual Klinik Klinik { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<KlinikServicesReception> KlinikServicesReceptions { get; set; }
    }
}
