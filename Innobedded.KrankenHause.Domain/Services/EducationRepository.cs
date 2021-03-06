using Innobedded.KrankenHause.Data.Entities;
using Innobedded.KrankenHause.Data.Context;
using Innobedded.KrankenHause.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Domain.Services
{
   public class EducationRepository:GenericRepositoy<Education>,IEducationRepository
    {
        public EducationRepository(KrankenHausDbContext dbContext):base(dbContext)
        {

        }
    }
}
