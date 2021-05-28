﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Data.Entities
{
   public class Sex
    {
        [Key]
        public int SexID { get; set; }


         [Display(Name ="Geschlecht Titel")]
        public string Title { get; set; }

        public virtual ICollection<Krank> Kranks { get; set; }
    }
}
