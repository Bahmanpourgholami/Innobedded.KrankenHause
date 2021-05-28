﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Innobedded.KrankenHause.Data.Entities
{
  public  class KlinikType
    {

        [Key]
        public int KlinikTypeID { get; set; }

        public string Title { get; set; }

        public virtual ICollection<Klinik> Kliniks { get; set; }
    }
}
