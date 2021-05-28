using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Data.Entities
{
   public class User
    {
        [Key]
        public int UserID { get; set; }
         
        public string UserName { get; set; }
        public string Password { get; set; }

        public string NameFamily { get; set; }

        public DateTime LastEnter { get; set; }


        public virtual ICollection<Reception> Receptions { get; set; }
    }
}
