using Innobedded.KrankenHause.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Domain.Repositories
{
   public interface IFachRepository:IGenericRepositoy<Fach>
    {
        Fach GetSpecialFach(string title);
    }
}
