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

        public string Name { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        public int KlinikTypeID { get; set; }

        public virtual KlinikType KlinikType { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }

        public virtual ICollection<Reception>  Receptions { get; set; }

    }
}
