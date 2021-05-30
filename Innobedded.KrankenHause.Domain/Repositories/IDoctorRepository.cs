using Innobedded.KrankenHause.Data.Entities;
using Innobedded.KrankenHause.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Domain.Repositories
{
  public  interface IDoctorRepository:IGenericRepositoy<Doctor>
    {

        IEnumerable<DoctorsViewModel> doctorsViewModels();

    }
}
