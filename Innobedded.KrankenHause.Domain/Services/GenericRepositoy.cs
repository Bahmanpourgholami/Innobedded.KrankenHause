using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Innobedded.KrankenHause.Domain.Repositories;
using Innobedded.KrankenHause.Data.Context;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Innobedded.KrankenHause.Domain.Services
{
    public class GenericRepositoy<TEntity> : IGenericRepositoy<TEntity> where TEntity : class
    {

        /// <summary>
        /// We Musst To this Variable Access haben.(from inherit Classes by Generic) 
        /// So Entweder internal oder protected benutzen
        /// </summary>
        /// <param name="krankenHausDbContext"></param>
        /// <param name="DbSet<TEntity> "></param>
        /// 
        protected KrankenHausDbContext _mycontext;
        protected DbSet<TEntity> _entities;
    
        public GenericRepositoy(KrankenHausDbContext krankenHausDbContext)
        {
            _mycontext = krankenHausDbContext;
            _entities = _mycontext.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _entities;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual TEntity GetById(object id)
        {

            //_mycontext.Set<TEntity>().AsNoTracking();
            return _entities.Find(id);
        }

        public virtual bool Insert(TEntity entity)
        {
            try
            {
                _entities.Add(entity);
                return true;

            }
            catch
            {

                return false;
            }
        }

        public virtual bool Update(TEntity entity)
        {
            try
            {
                _entities.Attach(entity);
                _mycontext.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool Delete(TEntity entity)
        {
            try
            {
                if(_mycontext.Entry(entity).State==EntityState.Detached)
                {
                    _entities.Attach(entity);
                }
                _entities.Remove(entity);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool Delete(object id)
        {
            try
            {
                var TempEntity = GetById(id);
                Delete(TempEntity);
                return true;
            }
            catch
            {
                return false;
            
            }
        }
        public void Save()
        {
            _mycontext.SaveChanges();
        }

  
    }
}
