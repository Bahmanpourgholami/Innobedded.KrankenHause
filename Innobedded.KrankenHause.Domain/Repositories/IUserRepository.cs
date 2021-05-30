﻿using Innobedded.KrankenHause.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Domain.Repositories
{
   public interface IUserRepository:IGenericRepositoy<User>
    {
        string UserEmail(int id);
        bool IsExsist(string username, string pass);
    }
}
