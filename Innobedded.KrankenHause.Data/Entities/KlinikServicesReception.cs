using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Data.Entities
{
  public  class KlinikServicesReception
    {
        /// <summary>
        /// KSR => KlinikServicesReception
        /// 
        /// 
        /// </summary>

        [Key]
        public int KSRID { get; set; }

        [Display(Name = "Art Service")]
        [Required(ErrorMessage = "Wählen Sie {0} Bitte!")]
        public int ServiceID { get; set; }

        [Display(Name = "Krank Rezeption")]
        [Required(ErrorMessage = "Wählen Sie {0} Bitte!")]
        public int ReceptionID { get; set; }

        [Display(Name = "Anzahl für Services")]
        public int ServiceCount { get; set; }


        public virtual KlinikService KlinikService { get; set; }

        public virtual Reception Reception { get; set; }

    }
}
