using FGA.Congressus2.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGA.Congressus2.Negocio.Interfaces
{
    public interface INegocio<T> where T: class
    {
        Task<NegocioResult<T>> Create(T entity);
        Task<NegocioResult<IQueryable<T>>> FindAll();
        Task<NegocioResult<T>> FindById(int entityId);
        Task Update(T entity);
        Task Delete(T entity);
        Task Delete(int entityId);
    }
}
