using FGA.Congressus2.Data.Repositories;
using FGA.Congressus2.Data.Repositories.Interfaces;
using FGA.Congressus2.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGA.Congressus2.Negocio.Negocio
{
    public class Negocio<T> : INegocio<T> where T: class
    {
        private readonly IRepository<T> Repository;
        public Negocio(IRepository<T> repository)
        {
            Repository = repository;
        }

        public virtual async Task<NegocioResult<T>> Create(T entity)
        {
            try { 
                await Repository.Create(entity);
                return NegocioResult<T>.Succeded();
            }catch(Exception e)
            {
                return new NegocioResult<T>(e);
            }
        }

        public virtual async Task<NegocioResult<IQueryable<T>>> FindAll()
        {
            var all = await Repository.FindAll();
            return NegocioResult<IQueryable<T>>.Succeded(all);
        }

        public virtual async Task<NegocioResult<T>> FindById(int entityId)
        {
            var entity = await Repository.FindById(entityId);
            return NegocioResult<T>.Succeded(entity);
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int entityId)
        {
            throw new NotImplementedException();
        }
    }
}
