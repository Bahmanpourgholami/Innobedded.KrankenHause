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
    public class UserRepository : GenericRepositoy<User>, IUserRepository
    {
        public UserRepository(KrankenHausDbContext dbContext):base(dbContext)
        {

        }

        public bool IsExsist(string username, string pass)
        {
            return _entities.Any(p => p.UserName == username && p.Password == pass);
            
            
        }

        public string UserEmail(int id)
        {
            return _entities.Find(id).Email;
        }
    }
}
