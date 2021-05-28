using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Data.Entities
{
  public  class Education
    {

        public int EduID { get; set; }

        public string Title { get; set; }


        public virtual ICollection<Krank> Kranks { get; set; }
    }
}
