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

        public string Name { get; set; }
        public string Family { get; set; }

        public string Address { get; set; }

        public DateTime Born { get; set; }


        public int SexID { get; set; }

        public int JobID { get; set; }
        public int EduID { get; set; }


        public virtual Sex Sex { get; set; }
        public virtual Job Job { get; set; }

        public virtual Education Education { get; set; }
    }
}
