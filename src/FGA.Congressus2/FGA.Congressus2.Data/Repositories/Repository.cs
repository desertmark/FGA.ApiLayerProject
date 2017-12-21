using FGA.Congressus2.Data.Context;
using FGA.Congressus2.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGA.Congressus2.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private readonly IdentityContext IdentityContext;
        private readonly Congressus2Entities Context;
        public Repository(IdentityContext idContext, Congressus2Entities context)
        {
            IdentityContext = idContext;
            Context = context;
        }

        public virtual async Task Create(T entity)
        {
            Context.Set<T>().Add(entity);
            await Context.SaveChangesAsync();
        }

        public virtual async Task<IQueryable<T>> FindAll()
        {
            return await Task.Run(() => Context.Set<T>().AsQueryable<T>());
        }

        public virtual async Task<T> FindById(int entityId)
        {
            
            return await Task.Run(() =>
            {
                try
                {
                    return Context.Set<T>().Find(entityId);
                }
                catch (Exception e)
                {
                    return null;
                }
                //return Context.Set<T>().Find(entityId);
            });
        }

        public virtual async Task Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
        }

        public virtual async Task Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();
        }

        public virtual async Task Delete(int entityId)
        {
            var entity = await FindById(entityId);
            await Delete(entity);
        }

    }
}
