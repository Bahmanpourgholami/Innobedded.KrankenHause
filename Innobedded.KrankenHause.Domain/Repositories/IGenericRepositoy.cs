using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Innobedded.KrankenHause.Domain.Repositories
{
   public interface IGenericRepositoy<TEntity> where TEntity:class
    {
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,
                          Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                          params Expression<Func<TEntity, object>>[] includeProperties);

        IEnumerable<TEntity> GetAll();
        
        TEntity GetById(object id);

        bool Insert(TEntity entity);

        bool Update(TEntity entity);

        bool Delete(TEntity entity);

        bool Delete(object id);

        void Save();

    }
}
