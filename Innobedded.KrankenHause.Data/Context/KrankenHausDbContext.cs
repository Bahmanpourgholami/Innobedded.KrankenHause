using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Innobedded.KrankenHause.Data.Entities;


namespace Innobedded.KrankenHause.Data.Context
{
   public class KrankenHausDbContext:DbContext
    {

        public DbSet<Doctor>  Doctors { get; set; }
        public DbSet<Fach> Faches { get; set; }


    }
}
