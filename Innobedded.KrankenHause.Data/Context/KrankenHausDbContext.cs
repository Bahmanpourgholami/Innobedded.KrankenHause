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

        public DbSet<Krank> Kranks { get; set; }
        public DbSet<Sex> Sexes { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Education> Educations { get; set; }

        public DbSet<Klinik> Kliniks { get; set; }
        public DbSet<KlinikType> KlinikTypes { get; set; }

        public DbSet<Insurance> Insurances { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<KlinikService> KlinikServices { get; set; }

        public DbSet<Reception> Receptions { get; set; }




    }
}
