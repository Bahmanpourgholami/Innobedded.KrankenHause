using Innobedded.KrankenHause.Data.Entities;
using Innobedded.KrankenHause.Domain.Repositories;
using Innobedded.KrankenHause.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Domain.Services
{
    public class FachRepository : GenericRepositoy<Fach>, IFachRepository
    {
        public FachRepository(KrankenHausDbContext dbContext) : base(dbContext)
        {

        }

        public string GetFachTitle(int id)
        {
            return _entities.Find(id).Title;
        }

        public Fach GetSpecialFach(string title)
        {
            //return _mycontext.Set<Fach>().Where(p=>p.Title.)
            return _entities.Where(p => p.Title.Contains(title)).FirstOrDefault();
        }
    }
}
