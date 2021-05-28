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

        public string Name { get; set; }

        public string Family { get; set; }
        
        public int FachID { get; set; }

        public int KlinikID { get; set; }
        public string Telefon { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        public virtual Fach Fach { get; set; }
        public virtual Klinik Klinik { get; set; }
    }
}
