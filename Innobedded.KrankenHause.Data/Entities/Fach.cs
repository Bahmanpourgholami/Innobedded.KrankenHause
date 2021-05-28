using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Data.Entities
{
   public class Fach
    {

        [Key]
        public int FachID { get; set; }

         public string Title { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }

    }
}
