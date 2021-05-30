using Innobedded.KrankenHause.Data.Context;
using Innobedded.KrankenHause.Data.Entities;
using Innobedded.KrankenHause.Domain.Repositories;
using Innobedded.KrankenHause.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Domain.Services
{
   public class DoctorRepository:GenericRepositoy<Doctor>,IDoctorRepository
    {
        public DoctorRepository(KrankenHausDbContext dbContext):base(dbContext)
        {

        }

        public IEnumerable<DoctorsViewModel> doctorsViewModels()
        {
            
          return  _mycontext.Doctors.Select(T => new DoctorsViewModel()
            {
                Telefon=T.Telefon,
                FachTitle=T.Fach.Title,
                Description=T.Description,
                Email=T.Email,
                Family=T.Family,
                Name=T.Name,
                KlinikName=T.Klinik.Name,
                Picture=T.Picture

            });
        }
    }
}
