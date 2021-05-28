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

        public int KrankID { get; set; }

        public int KlinikID { get; set; }

        public int UserID { get; set; }

        public bool Accept { get; set; }
        public string CauseDescription { get; set; }

        public DateTime ReceptionTime { get; set; }


        public virtual Krank Krank { get; set; }
        public virtual Klinik Klinik { get; set; }

        public virtual User User { get; set; }
    }
}
