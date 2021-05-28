using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Data.Entities
{
   public class KlinikService
    {

        [Key]
        public int ServiceID { get; set; }

         [Display(Name ="Service Titel")]
        public string Title { get; set; }

        [Display(Name = "Beschreibung")]
        [DataType(DataType.MultilineText)]
        [MaxLength(350)]
        public string Description { get; set; }

        [Display(Name = "Service Bild")]
        public string Picture { get; set; }

         [Display(Name ="Kosten")]
        public double Cost { get; set; }


        public virtual ICollection<KlinikServicesReception> KlinikServicesReceptions { get; set; }

    }
}
